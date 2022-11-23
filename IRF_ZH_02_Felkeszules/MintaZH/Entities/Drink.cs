using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH.Abstractions
{
    public class Drink : Product
    {
        public override void Display()
        {
            this.BackColor = Color.LightBlue;
        }
    }
}
