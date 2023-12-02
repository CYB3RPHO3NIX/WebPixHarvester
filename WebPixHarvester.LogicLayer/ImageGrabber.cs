using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using WebPixHarvester.LogicLayer.Models;

namespace WebPixHarvester.LogicLayer
{
    public class ImageGrabber : ILinkGrabber
    {
        public List<string> GrabAllImageLinksFrom(string url, GrabberOptions options)
        {
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).GetAwaiter().GetResult();

            var document = new HtmlDocument();
            document.LoadHtml(html);

            var imageLinks = new List<string>();

            var imgNodes = GetImageNodes(document, options);

            if (imgNodes != null)
            {
                foreach (var node in imgNodes)
                {
                    var src = node.GetAttributeValue(options.TargetAttribute, "");
                    if (!string.IsNullOrEmpty(src))
                    {
                        imageLinks.Add(src);
                    }
                }
            }
            return imageLinks;
        }

        private IEnumerable<HtmlNode>? GetImageNodes(HtmlDocument document, GrabberOptions options)
        {
            if (options.TagName != null && options.ClassName != null)
            {
                return document.DocumentNode.SelectNodes($"//{options.TagName}[@class='{options.ClassName}']");
            }
            else if (options.ImageType != null)
            {
                return document.DocumentNode.SelectNodes($"//{options.TagName}[@src][contains(@src, '{options.ImageType}')]");
            }
            else
            {
                return document.DocumentNode.SelectNodes($"//{options.TagName}[@src]");
            }
        }
    }
}