using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public class DisabledLabel : Label
    {
        public DisabledLabel() { }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Enabled)
            {
                //use normal realization
                base.OnPaint(e);
                return;
            }
            //custom drawing
            using (Brush aBrush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(Text, Font, aBrush, ClientRectangle);
            }
        }
    }
}
