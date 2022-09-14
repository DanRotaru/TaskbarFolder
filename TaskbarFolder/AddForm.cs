using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class AddForm : Form
    {
        private bool mouseDown = false, lightTheme = false;
        private Point lastLocation;

        private static readonly Helpers helpers = new Helpers();
        private static readonly IniFile ini = Main.ini;

        public AddForm()
        {
            InitializeComponent();

            // Form shadow & border
            Main.setTimeout(() => {
                helpers.ApplyShadows(this);
            }, 200);

            helpers.RoundCorners(dragPanel);

            AllowDrop = true;

            if (string.IsNullOrEmpty(ini.Read("theme")))
            {
                ini.Write("theme", "dark");
                ini.Write("min", "false");
                ini.Write("ontop", "false");
                ini.Write("save_location", "false");
                ini.Write("location_x", "0");
                ini.Write("location_y", "0");
                ini.Write("rows", "0");
                ini.Write("icon", "");
                ini.Write("apps", "");
            }
        }


        private void AddForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            //dragPanel.BackColor = Color.FromArgb(27, 27, 27);
        }

        private void AddForm_DragLeave(object sender, EventArgs e)
        {
            //dragPanel.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void AddForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            loadFile(files);
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void loadFile(string[] files)
        {
            string apps = "";
            foreach (string file in files)
            {
                Console.WriteLine(file);
                apps += file + ";";
            }
            ini.Write("apps", apps);
            MessageBox.Show("App list was successfully updated! Please restart app!", "Success!");
        }

        private void selectFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFile(fileDialog.FileNames);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskbarFolder.ini");
        }

        private void addFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(Location.X - lastLocation.X + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void AddForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void addFormClose_MouseLeave(object sender, EventArgs e)
        {
            _ = lightTheme
                    ? addFormClose.Image = Properties.Resources.closeSettingsLight
                    : addFormClose.Image = Properties.Resources.closeSettings;
        }

        private void addFormClose_MouseEnter(object sender, EventArgs e)
        {
            _ = lightTheme
                    ? addFormClose.Image = Properties.Resources.closeSettingsHoverLight
                    : addFormClose.Image = Properties.Resources.closeSettingsHover;
        }
    }
}
