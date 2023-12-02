using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPixHarvester.Data.Models
{
    public class ImageDTO
    {
        public Guid ImageId { get; } = Guid.NewGuid();
        public string ImageUrl { get; set; }
    }
}
