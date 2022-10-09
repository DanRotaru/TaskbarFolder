using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace TaskbarFolder
{
    public class DisabledLabel : Label
    {
        public DisabledLabel() { }

        private TextRenderingHint _hint = TextRenderingHint.SystemDefault;
        public TextRenderingHint TextRenderingHint
        {
            get { return this._hint; }
            set { this._hint = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Enabled)
            {
                //use normal realization
                e.Graphics.TextRenderingHint = TextRenderingHint;
                base.OnPaint(e);
                return;
            }
            //custom drawing
            using (Brush aBrush = new SolidBrush(ForeColor))
            {
                e.Graphics.DrawString(Text, Font, aBrush, ClientRectangle);
            }
        }
    }
}
