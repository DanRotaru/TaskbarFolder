using System;
using System.Drawing;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Label = System.Windows.Forms.Label;

namespace TaskbarFolder
{
    public partial class ContextMenuForm : Form
    {
        private static readonly Helpers helpers = new Helpers();
        private bool lightTheme;

        public ContextMenuForm()
        {
            InitializeComponent();
            ChangeTheme(Main.lightTheme);

            Main.setTimeout(() => {
                helpers.ApplyShadows(this);
            }, 200);
            
        }

        private void ContextMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonHover(object sender, EventArgs e)
        {
            Panel btn = sender as Panel;
            _ = Main.lightTheme
                    ? btn.BackColor = Color.FromArgb(230, 230, 230)
                    : btn.BackColor = Color.FromArgb(57, 57, 57);
        }

        private void buttonHoverLeave(object sender, EventArgs e)
        {
            Panel btn = sender as Panel;

            _ = Main.lightTheme
                    ? btn.BackColor = Color.FromArgb(249, 249, 249)
                    : btn.BackColor = Color.FromArgb(32, 32, 32);
        }


        public void ChangeTheme(bool lightTheme)
        {
            if (lightTheme)
            {
                lightTheme = true;
                Main.lightTheme = true;
                BackColor = Color.FromArgb(249, 249, 249);
                delimiter.BackColor = Color.FromArgb(230, 230, 230);

                ControlsForeach(Color.Black, Color.FromArgb(249, 249, 249));

                foreach (Form f in Application.OpenForms)
                    f.BackColor = Color.FromArgb(249, 249, 249);
            }

            else
            {
                lightTheme = false;
                Main.lightTheme = false;
                BackColor = Color.FromArgb(32, 32, 32);
                delimiter.BackColor = Color.FromArgb(57, 57, 57);

                ControlsForeach(Color.White, Color.FromArgb(32, 32, 32));

                foreach (Form f in Application.OpenForms)
                    f.BackColor = Color.FromArgb(32, 32, 32);
            }
        }

        public void ControlsForeach(Color labelColor, Color panelColor)
        {
            foreach (Control c in Controls)
            {
                if (c is Panel)
                {
                    if (c.Tag.ToString().Equals("delimiter"))
                        continue;

                    helpers.RoundCorners(c, 5);

                    c.BackColor = panelColor;
                    c.MouseEnter += buttonHover;
                    c.MouseLeave += buttonHoverLeave;

                    foreach (Control label in c.Controls)
                    {
                        if (label is Label)
                        {
                            label.ForeColor = labelColor;
                        }
                    }
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Main"] as Main) != null)
            {
                Application.OpenForms["Main"].BringToFront();
                Application.OpenForms["Main"].Show();
            }
            else
            {
                Form main = new Main();
                Rectangle workingArea = Screen.GetWorkingArea(this);
                main.Location = new Point(workingArea.Width / 2 - 220, workingArea.Height / 2 - 397);
                main.Show();
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //Form is already open
            if ((Application.OpenForms["SettingsForm"] as SettingsForm) != null)
            {
                Application.OpenForms["SettingsForm"].BringToFront();
            }
            else
            {
                SettingsForm form = new SettingsForm();
                Rectangle workingArea = Screen.GetWorkingArea(this);
                form.Location = new Point(workingArea.Width / 2 - 220, workingArea.Height / 2 - 397);
                form.Show();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRestarting = false;
            Properties.Settings.Default.Exiting = true;
            Application.Exit();
        }

        private void ContextMenuForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!lightTheme) 
                ChangeTheme(Main.lightTheme);
        }
    }
}
