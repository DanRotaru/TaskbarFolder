using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class AddFormTest : Form
    {
        private static readonly Helpers helpers = new Helpers();

        public AddFormTest()
        {
            InitializeComponent();

            Main.setTimeout(() => {
                helpers.ApplyShadows(this);
            }, 200);

        }

        private void AddFormList_Load(object sender, EventArgs e)
        {

        }

        private void AddFormList_DragEnter(object sender, DragEventArgs e)
        {
            dragging_text.Visible = true;
        }

        private void AddFormList_DragLeave(object sender, EventArgs e)
        {
            dragging_text.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
