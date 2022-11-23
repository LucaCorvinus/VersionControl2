using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH.Abstractions
{
    public class Food : Product
    {
        public override void Display()
        {
            if (Calories <= 750)
            {
                this.BackColor = Color.LightGreen;
            }
            if (Calories > 750 && Calories <= 1000)
            {
                this.BackColor = Color.LightYellow;
            }
            if (Calories > 1000)
            {
                this.BackColor= Color.Salmon;
            }
        }

        public string Description { get; set; }

        public Food()
        {
            MouseClick += Food_MouseClick;
        }

        private void Food_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MessageBox.Show(string.Format("{0}\n{1}", Title, Description));
        }
    }
}
