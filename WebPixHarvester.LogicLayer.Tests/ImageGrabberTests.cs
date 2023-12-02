
using WebPixHarvester.LogicLayer.Models;
using Xunit;
namespace WebPixHarvester.LogicLayer.Tests
{
    public class ImageGrabberTests
    {
        [Fact]
        public void Test1()
        {
            ImageGrabber grabber = new ImageGrabber();
            GrabberOptions options = new GrabberOptions() { ClassName = "rel-link", TagName = "a", TargetAttribute = "href"};
            //var result = grabber.GrabAllImageLinksFrom(url, options);
        }
    }
}