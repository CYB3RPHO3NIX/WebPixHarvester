using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPixHarvester.LogicLayer.Models
{
    public class GrabberOptions
    {
        public string? TagName{ get; set; }
        public string? ClassName { get; set; }
        public string? TargetAttribute { get; set; }
        public string? ImageType { get; set; }
    }
}
