using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Windows.Forms.Label;

namespace TaskbarFolder
{
    public partial class ContextMenuForm : Form
    {
        private static readonly Helpers helpers = new Helpers();
        private static readonly IniFile ini = Main.ini;

        private bool lightTheme = ini.Read("theme").Equals("light");

        public ContextMenuForm()
        {
            InitializeComponent();

            Main.setTimeout(() => {
                helpers.ApplyShadows(this);
                ChangeTheme(lightTheme);
            }, 200);
            
        }

        private void ContextMenuForm_Load(object sender, EventArgs e)
        {

        }

        public Button addBtn;

        private void buttonHover(object sender, EventArgs e)
        {
            Panel btn = sender as Panel;
            _ = lightTheme
                    ? btn.BackColor = Color.FromArgb(210, 210, 210)
                    : btn.BackColor = Color.FromArgb(57, 57, 57);
        }

        private void buttonHoverLeave(object sender, EventArgs e)
        {
            Panel btn = sender as Panel;

            _ = lightTheme
                    ? btn.BackColor = Color.FromArgb(220, 220, 220)
                    : btn.BackColor = Color.FromArgb(32, 32, 32);
        }


        public void ChangeTheme(bool theme)
        {
            //ControlsForeach(Color.Black, Color.FromArgb(230, 230, 230), Color.FromArgb(249, 249, 249));
            ControlsForeach(Color.FromArgb(200, 200, 200), Color.FromArgb(32, 32, 32), Color.FromArgb(32, 32, 32));

            if (theme)
            {
                
            }

            else
            {
                
            }
        }

        public void h(object sender, EventArgs e)
        {
            Label l = sender as Label;

            foreach (Control c in Controls)
            {
                if (c is Panel)
                {
                    if (c.Tag.ToString().Equals("delimiter"))
                        continue;

                    else if (c.Tag.ToString().Equals(l.Tag.ToString()))
                    {
                        c.BackColor = Color.FromArgb(57, 57, 57);
                    }

                }
            }
        }
        
        private void label2_EnabledChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
        }

        public void ControlsForeach(Color labelColor, Color panelColor, Color FormColor)
        {
            BackColor = FormColor;
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
                            //label.ForeColor = Color.White;
                            label.ForeColor = SystemColors.Control;
                            //label.MouseHover += buttonHover;
                            //label.MouseLeave += buttonHoverLeave;
                        }
                    }
                }
            }
        }

        public static void setTimeout(Action action, int ms)
        {
            Task.Delay(ms).ContinueWith((task) =>
            {
                action();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form main = System.Windows.Forms.Application.OpenForms["Main"];
            main.BringToFront();
            main.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Form is already open
            if ((System.Windows.Forms.Application.OpenForms["SettingsForm"] as SettingsForm) != null)
            {
                System.Windows.Forms.Application.OpenForms["SettingsForm"].BringToFront();
            }
            else
            {
                SettingsForm form = new SettingsForm();
                Rectangle workingArea = Screen.GetWorkingArea(this);
                form.Location = new Point(workingArea.Width / 2 - 220, workingArea.Height / 2 - 397);
                form.Show();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRestarting = false;
            Properties.Settings.Default.Exiting = true;
            System.Windows.Forms.Application.Exit();
        }
    }
}
