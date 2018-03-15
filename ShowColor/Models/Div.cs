using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace ShowColor.Models
{
    public class Div 
    {
        public string ColorName { get; set; }
        public int ColorR { get; set; }
        public int ColorG { get; set; }
        public int ColorB { get; set; }
        public int ColorVaule { get; set; }

        public Div(Color c) 
        {
            this.ColorR = c.R;
            this.ColorG = c.G;
            this.ColorB = c.B;
            this.ColorVaule = c.R * 256 * 256 + c.G * 256 + c.B;
            int total = c.R + c.G + c.B;
            this.ColorName = c.Name;
        }
    }
}