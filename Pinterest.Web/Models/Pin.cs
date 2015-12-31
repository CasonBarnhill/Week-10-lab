using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pinterest.Web.Models
{
    public class Pin    
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}