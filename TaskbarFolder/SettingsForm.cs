using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class SettingsForm : Form
    {
        private static readonly Helpers helpers = new Helpers();
        private static readonly IniFile ini = Main.ini;

        private bool 
            fromForm1 = true,
            mouseDown = false,
            
            lightTheme = ini.Read("theme").Equals("light");

        private Point lastLocation;

        public SettingsForm()
        {
            InitializeComponent();

            ChangeTheme(lightTheme);

            // Form shadow & border
            Main.setTimeout(() => {
                helpers.ApplyShadows(this);
            }, 200);

            if (IsTrue(Main.min))
            {
                minimalView.Checked = true;
            }

            if (IsTrue(Main.ontop))
            {
                onTopCheck.Checked = true;
            }

            if (IsTrue(Main.save_location))
            {
                saveLocationCheck.Checked = true;
                location_x_val.Text = Main.location_x;
                location_y_val.Text = Main.location_y;
                location_x_val.Enabled = true;
                location_y_val.Enabled = true;
            }

            if (Main.useRows)
            {
                useRowsIndex.Checked = true;
                rows.Text = Main.rows.ToString();
                rows.Enabled = true;
            }

            if (!IsTrue(Main.tray))
                pinToTray.Checked = false;

            helpers.RoundCorners(textBoxPadding1);
            helpers.RoundCorners(textBoxPadding2);
            helpers.RoundCorners(textBoxPadding3);
        }

        public void ChangeTheme(bool theme, bool agresive = true)
        {
            if (theme)
            {
                themeLight.Checked = true;
                themeDark.Checked = false;
                lightTheme = true;

                //BackColor = Color.FromArgb(242, 243, 247);
                BackColor = Color.FromArgb(249, 249, 249);

                themeIcon.Image = Properties.Resources.themeLight;
                minimalViewIcon.Image = Properties.Resources.minimalViewLight;
                onTopIcon.Image = Properties.Resources.ontopLight;
                locationIcon.Image = Properties.Resources.locationLight;
                gridView.Image = Properties.Resources.gridLight;
                pinToTrayImg.Image = Properties.Resources.pinLight;
                settingsClose.Image = Properties.Resources.closeSettingsLight;

                ControlsForeach(Color.Black, Color.FromArgb(230, 230, 230), Color.FromArgb(249, 249, 249));
                form_link.ForeColor = Color.Black;
                Main.lightTheme = true;

                foreach (Form f in Application.OpenForms)
                    f.BackColor = Color.FromArgb(249, 249, 249);

                addBtn.BackColor = Color.FromArgb(220, 220, 220);
                addBtnText.ForeColor = Color.Black;
            }

            else
            {
                if (!agresive)
                    return;

                themeLight.Checked = false;
                themeDark.Checked = true;
                lightTheme = false;

                BackColor = Color.FromArgb(32, 32, 32);

                themeIcon.Image = Properties.Resources.theme;
                minimalViewIcon.Image = Properties.Resources.minimalView;
                onTopIcon.Image = Properties.Resources.ontop;
                locationIcon.Image = Properties.Resources.location;
                gridView.Image = Properties.Resources.grid;
                pinToTrayImg.Image = Properties.Resources.pin;
                settingsClose.Image = Properties.Resources.closeSettings;

                ControlsForeach(Color.FromArgb(200, 200, 200), Color.FromArgb(43, 43, 43), Color.FromArgb(32, 32, 32));
                form_title.ForeColor = Color.White;
                form_menu.ForeColor = Color.White;
                form_link.ForeColor = Color.FromArgb(153, 235, 255);
                Main.lightTheme = false;

                foreach (Form f in Application.OpenForms)
                    f.BackColor = Color.FromArgb(32, 32, 32);

                addBtn.BackColor = Color.FromArgb(55, 55, 55);
                addBtnText.ForeColor = Color.White;
            }

            heart_icon.ForeColor = Color.Red;
            
        }

        public void ControlsForeach(Color labelColor, Color panelColor, Color FormColor)
        {
            BackColor = FormColor;
            foreach (Control c in Controls)
            {
                if (c is Panel)
                {
                    helpers.RoundCorners(c);

                    c.BackColor = panelColor;

                    foreach (Control label in c.Controls)
                    {
                        if (label is Label || label is CheckBox || label is RadioButton)
                        {
                            label.ForeColor = labelColor;
                        }
                        else if (label is TextBox || label is Panel)
                        {
                            if (label is Panel)
                                helpers.RoundCorners(label);

                            label.BackColor = FormColor;
                            label.ForeColor = labelColor;
                        }
                    }
                }
                else if (c is Label)
                {
                    c.ForeColor = labelColor;
                }
            }
        }

        private void me_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://danrotaru.github.io/");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            fromForm1 = false;
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
                Main.save_location = "true";
                Main.location_x = location_x_val.Text;
                Main.location_y = location_y_val.Text;
                Main.locationChanged = "";
            }

            else
            {
                location_x_val.Enabled = false;
                location_y_val.Enabled = false;
                ini.Write("save_location", "false");
                Main.save_location = "false";
                Main.locationChanged = "true";

            }
        }

        private void location_x_val_TextChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("location_x", location_x_val.Text);
            Main.location_x = location_x_val.Text;
        }

        private void location_y_val_TextChanged(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("location_y", location_y_val.Text);
            Main.location_y = location_y_val.Text;
        }

        private void themeLight_Click(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("theme", "light");
            ChangeTheme(true);
        }

        private void themeDark_Click(object sender, EventArgs e)
        {
            if (fromForm1) return;

            ini.Write("theme", "dark");
            ChangeTheme(false);
        }

        public bool IsTrue(string value)
        {
            if (value.Equals("true") || value.Equals("1"))
                return true;
            else
                return false;
        }

        private void settingsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsClose_MouseEnter(object sender, EventArgs e)
        {
            _ = lightTheme
                    ? settingsClose.Image = Properties.Resources.closeSettingsHoverLight
                    : settingsClose.Image = Properties.Resources.closeSettingsHover;
        }

        private void settingsClose_MouseLeave(object sender, EventArgs e)
        {
            _ = lightTheme
                    ? settingsClose.Image = Properties.Resources.closeSettingsLight
                    : settingsClose.Image = Properties.Resources.closeSettings;
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanRotaru/TaskbarFolder");
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void rows_TextChanged(object sender, EventArgs e)
        {
            if (fromForm1) 
                return;

            if (useRowsIndex.Checked)
            {
                rows.Enabled = true;
                ini.Write("rows", rows.Text);
            }

            else
            {
                rows.Enabled = false;
                ini.Write("rows", "0");
            }
        }

        private void pinToTray_CheckedChanged(object sender, EventArgs e)
        {
            if (fromForm1)
                return;

            if (pinToTray.Checked)
            {
                ini.Write("tray", "true");
                Main.trayFromSettings = true;
            }

            else
            {
                ini.Write("tray", "false");
                Main.trayFromSettings = false;
            }
        }

        private void SettingsForm_Load_1(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if ((Application.OpenForms["AddForm"] as AddForm) != null)
            {
                Application.OpenForms["AddForm"].BringToFront();
                //Form is already open
                //Application.OpenForms["SettingsForm"].Close();
            }
            else
            {
                AddForm form = new AddForm();
                form.Show();
                Close();
            }
        }

        private void addBtn_MouseEnter(object sender, EventArgs e)
        {
            _ = lightTheme
                    ? addBtn.BackColor = Color.FromArgb(210, 210, 210)
                    : addBtn.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void addBtn_MouseLeave(object sender, EventArgs e)
        {
            _ = lightTheme
                    ? addBtn.BackColor = Color.FromArgb(220, 220, 220)
                    : addBtn.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void iniFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskbarFolder.ini");
        }

        private void addBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(Location.X - lastLocation.X + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void SettingsForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
