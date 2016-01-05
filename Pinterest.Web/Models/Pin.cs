using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pinterest.Web.Models
{
    public class Pin
    {
        public int Id { get; set; }
        [DataType(DataType.Url)]
        public string LinkToPost { get; set; }
        [DataType(DataType.Url)]
        public string LinkToImage { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}