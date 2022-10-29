using CJYFZB_week_07.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJYFZB_week_07.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        
        public Present(Color box, Color ribbon)
        {
            BoxColor = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
        }
    }
}
