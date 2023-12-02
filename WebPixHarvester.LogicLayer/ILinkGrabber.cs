using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPixHarvester.LogicLayer.Models;

namespace WebPixHarvester.LogicLayer
{
    public interface ILinkGrabber
    {
        List<string> GrabAllImageLinksFrom(string url, GrabberOptions options);
    }
}
