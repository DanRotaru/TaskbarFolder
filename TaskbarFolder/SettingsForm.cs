using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class SettingsForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public IniFile ini = new IniFile("TaskbarFolder.ini");

        private bool fromForm1 = true;

        public SettingsForm()
        {
            InitializeComponent();

            if (Form1.lightTheme)
            {
                themeLight.Checked = true;
                themeDark.Checked = false;

                //BackColor = Color.FromArgb(242, 243, 247);
                BackColor = Color.FromArgb(249, 249, 249);

                themeIcon.Image = Properties.Resources.themeLight;
                minimalViewIcon.Image = Properties.Resources.minimalViewLight;
                onTopIcon.Image = Properties.Resources.ontopLight;
                locationIcon.Image = Properties.Resources.locationLight;
            }

            foreach (Control c in Controls)
            {
                if (c is Panel)
                {
                    RoundCorners(c);

                    
                    if (Form1.lightTheme)
                    {
                        c.BackColor = Color.FromArgb(230, 230, 230);

                        foreach (Control label in c.Controls)
                        {
                            if (label is Label || label is CheckBox || label is RadioButton)
                            {
                                label.ForeColor = Color.Black;
                            }
                            else if (label is TextBox || label is Panel)
                            {
                                if (label is Panel)
                                    RoundCorners(label);

                                //label.BackColor = Color.FromArgb(251, 251, 251);
                                label.BackColor = Color.FromArgb(243, 243, 243);
                                label.ForeColor = Color.Black;
                            }
                        }

                    }
                }
                else if(c is Label)
                {
                    if (Form1.lightTheme)
                        c.ForeColor = Color.Black;
                }
            }

            if (IsTrue(Form1.min))
            {
                minimalView.Checked = true;
            }

            if (IsTrue(Form1.ontop))
            {
                onTopCheck.Checked = true;
            }

            if (IsTrue(Form1.save_location))
            {
                saveLocationCheck.Checked = true;
                location_x_val.Text = Form1.location_x;
                location_y_val.Text = Form1.location_y;
                location_x_val.Enabled = true;
                location_y_val.Enabled = true;
            }

            if (Form1.useColumns)
            {
                useColumnsIndex.Checked = true;
                columns.Text = Form1.columns.ToString();
                columns.Enabled = true;
            }

            RoundCorners(textBoxPadding1);
            RoundCorners(textBoxPadding2);
            RoundCorners(textBoxPadding3);
        }

        private void me_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://danrotaru.github.io/");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            fromForm1 = false;
        }
        public void RoundCorners(Control el, int radius = 10)
        {
            el.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, el.Width, el.Height, radius, radius));
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minimalView_CheckedChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            if (minimalView.Checked)
                ini.Write("min", "true");

            else
                ini.Write("min", "false");
        }

        private void ontop_CheckedChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            if (onTopCheck.Checked)
                ini.Write("ontop", "true");

            else
                ini.Write("ontop", "false");
        }

        private void saveLocationCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            if (saveLocationCheck.Checked)
            {
                location_x_val.Enabled = true;
                location_y_val.Enabled = true;
                ini.Write("save_location", "true");
                ini.Write("location_x", location_x_val.Text);
                ini.Write("location_y", location_y_val.Text);
                Form1.save_location = "true";
                Form1.location_x = location_x_val.Text;
                Form1.location_y = location_y_val.Text;
                Form1.locationChanged = "";
            }

            else
            {
                location_x_val.Enabled = false;
                location_y_val.Enabled = false;
                ini.Write("save_location", "false");
                Form1.save_location = "false";
                Form1.locationChanged = "true";

            }
        }

        private void location_x_val_TextChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("location_x", location_x_val.Text);
            Form1.location_x = location_x_val.Text;
        }

        private void location_y_val_TextChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("location_y", location_y_val.Text);
            Form1.location_y = location_y_val.Text;
        }

        private void themeLight_Click(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("theme", "light");
        }

        private void themeDark_Click(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("theme", "dark");
        }

        public bool IsTrue(string value)
        {
            if (value.Equals("true") || value.Equals("1"))
                return true;
            else
                return false;
        }

        private void columns_TextChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            if (useColumnsIndex.Checked)
            {
                columns.Enabled = true;
                ini.Write("columns", columns.Text);
            }

            else
            {
                columns.Enabled = false;
                ini.Write("columns", "0");
            }
        }
    }
}
