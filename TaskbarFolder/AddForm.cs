using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class AddForm : Form
    {
        private bool mouseDown = false, lightTheme = false;
        private Point lastLocation;

        private static readonly Helpers helpers = new Helpers();
        private static readonly IniFile ini = Main.ini;

        private string apps_text = ini.Read("apps");
        private string[] apps;
        private int appsIndex = 0;

        public AddForm()
        {
            InitializeComponent();

            // Form shadow & border
            Main.setTimeout(() => {
                helpers.ApplyShadows(this);
            }, 200);

            helpers.RoundCorners(dragPanel);
            apps = apps_text.Split(';');

            if (string.IsNullOrEmpty(ini.Read("theme")))
            {
                ini.Write("theme", "dark");
                ini.Write("min", "false");
                ini.Write("ontop", "false");
                ini.Write("tray", "true");
                ini.Write("save_location", "false");
                ini.Write("location_x", "0");
                ini.Write("location_y", "0");
                ini.Write("rows", "0");
                ini.Write("icon", "");
                ini.Write("apps", "");

                radioAppsChecker(true);
            }

            else
            {
                if (string.IsNullOrEmpty(apps_text))
                {
                    // no apps
                    radioAppsChecker(true);
                }
                else
                {
                    radioAppsChecker(false);
                    appsLoop();
                }
            }
        }


        private void AddForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            //dragPanel.BackColor = Color.FromArgb(27, 27, 27);

            radioAppsChecker(true);
        }

        private void AddForm_DragLeave(object sender, EventArgs e)
        {
            //dragPanel.BackColor = Color.FromArgb(32, 32, 32);

            radioAppsChecker(false);
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
            //addStringElement

            foreach (string file in files)
            {
                apps = addStringElement(file);
            }
            /*

            string apps = "";
            foreach (string file in files)
            {
                Console.WriteLine(file);
                apps += file + ";";
            }
            ini.Write("apps", apps);
            */

            //MessageBox.Show("App list was successfully updated! Please restart app!", "Success!");
            apps_text = string.Join(";", apps);
            ini.Write("apps", apps_text);
            appsLoop();
            radioAppsChecker(false);
        }

        private void selectFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

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

        private void appsLoop()
        {
            appsIndex = 0;
            editAppsPanel.Controls.Clear();

            foreach (string app in apps)
            {
                string appPath = app,
                    appIcon = app;

                if (app.IndexOf("|") > -1)
                {
                    string[] split = app.Split('|');
                    appPath = split[0];
                    appIcon = split[1];
                }

                if (!string.IsNullOrEmpty(app))
                {
                    editAppsPanel.HorizontalScroll.Maximum = 0;
                    editAppsPanel.VerticalScroll.Visible = false;
                    editAppsPanel.HorizontalScroll.Visible = false;
                    editAppsPanel.AutoScroll = true;
                    addApp(appPath, appIcon);
                }  
            }

            radioEditApps.Text = "Edit app list (" + appsIndex + ")";
        }

        private void panelHover(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void panelHoverOut(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void radioAppsChecker(bool addAppsChecked = true)
        {
            if (addAppsChecked)
            {
                radioAddApps.Checked = true;
                radioEditApps.Checked = false;
                dragPanel.Visible = true;
                editAppsPanel.Visible = false;
                editAppsInfo.Visible = false;
                byPanel.Visible = false;
            }
            
            else
            {
                radioEditApps.Checked = true;
                radioAddApps.Checked = false;
                dragPanel.Visible = false;
                editAppsPanel.Visible = true;
                editAppsInfo.Visible = true;
                byPanel.Visible = true;
            }
        }

        private void radioAppsCheck(object sender, EventArgs e)
        {
            radioAppsChecker(radioAddApps.Checked);
        }

        private void ImageClickEvent(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = false
            };

            PictureBox img = sender as PictureBox;
            string tag = img.Tag.ToString();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Replace " + img.Tag + " with " + fileDialog.FileName);
                if (tag != null)
                {
                    if (tag.IndexOf("|") > -1)
                    {
                        string onlyIcon = tag.Split('|')[1];
                        apps = replaceStringElement(onlyIcon, fileDialog.FileName);
                    }

                    else
                        apps = replaceStringElement(tag, tag + "|" + fileDialog.FileName);

                    apps_text = string.Join(";", apps);
                    ini.Write("apps", apps_text);
                    appsLoop();
                }

                //loadFile(fileDialog.FileNames);
            }
        }

        private void AppClickEvent(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = false
            };

            Panel p = sender as Panel;
            string tag = p.Tag.ToString();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Replace " + img.Tag + " with " + fileDialog.FileName);
                if (tag != null)
                {
                    if (tag.IndexOf("|") > -1)
                    {
                        string onlyApp = tag.Split('|')[0];
                        apps = replaceStringElement(onlyApp, fileDialog.FileName);
                    }

                    else
                        apps = replaceStringElement(tag, fileDialog.FileName);

                    apps_text = string.Join(";", apps);
                    ini.Write("apps", apps_text);
                    appsLoop();
                }

                //loadFile(fileDialog.FileNames);
            }
        }

        private void addApp(string appLocation, string iconLocation)
        {
            string fileName = appLocation.StartsWith("http") ? "Website" : Path.GetFileNameWithoutExtension(appLocation);

            Panel appPanel = new Panel
            {
                Size = new Size(655, 64),
                Tag = appLocation,
                BackColor = Color.FromArgb(43, 43, 43)
            };

            int y = appsIndex * 64;
            if (appsIndex > 0)
            {
                y += appsIndex * 5;
            }

            appPanel.Location = new Point(0, y);
            appPanel.Cursor = Cursors.Hand;

            DisabledLabel appTitle = new DisabledLabel
            {
                AutoSize = false,
                Enabled = false,
                Size = new Size(500, 20),
                Location = new Point(64, 12),
                AutoEllipsis = true,
                Font = new Font("Segoe UI Semibold", 9F),
                ForeColor = Color.White,
                Text = fileName
            };
            appPanel.Controls.Add(appTitle);

            DisabledLabel appPath = new DisabledLabel
            {
                AutoSize = false,
                Enabled = false,
                Size = new Size(500, 20),
                AutoEllipsis = true,
                Location = new Point(64, 32),
                Font = new Font("Segoe UI", 7.8F),
                ForeColor = Color.FromArgb(200, 200, 200),
                Text = appLocation
            };
            appPanel.Controls.Add(appPath);

            helpers.RoundCorners(appPanel);

            PictureBox img = new PictureBox
            {
                Tag = appLocation.Equals(iconLocation) ? appLocation : appLocation + "|" + iconLocation,
                Location = new Point(12, 12),
                Size = new Size(36, 36),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            img.Click += ImageClickEvent;
            toolTip1.SetToolTip(img, "Select new app icon");

            Bitmap appIcon;
            if (appLocation.StartsWith("http"))
            {
                if (iconLocation != appLocation)
                    appIcon = helpers.getIcon(iconLocation, appLocation);
                else
                    _ = lightTheme
                           ? appIcon = Properties.Resources.webLight
                           : appIcon = Properties.Resources.web;
            }
            else
                appIcon = helpers.getIcon(iconLocation, appLocation);

            img.Image = appIcon;

            appPanel.Controls.Add(img);

            appPanel.MouseEnter += panelHover;
            appPanel.MouseLeave += panelHoverOut;
            appPanel.Click += AppClickEvent;


            PictureBox remove = new PictureBox
            {
                Tag = appLocation.Equals(iconLocation) ? "remove-" + appLocation : "remove-" + appLocation + "|" + iconLocation,
                Image = lightTheme ? Properties.Resources.closeSettingsLight
                    : addFormClose.Image = Properties.Resources.closeSettings,

                Location = new Point(615, 20),
                Size = new Size(25, 25),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            remove.Click += Remove_Click;
            toolTip1.SetToolTip(remove, "Remove app");

            appPanel.Controls.Add(remove);

            editAppsPanel.Controls.Add(appPanel);

            // Fix panel size
            if (editAppsPanel.VerticalScroll.Visible)
            {
                foreach (Control p in editAppsPanel.Controls)
                {
                    if (p is Panel)
                    {
                        p.Size = new Size(550, 64);
                        helpers.RoundCorners(p);

                        foreach (Control i in p.Controls)
                        {
                            if (i is PictureBox && i.Tag != null && i.Tag.ToString().StartsWith("remove-"))
                            {
                                i.Location = new Point(510, 20);
                            }
                        }
                    }
                }
            }

            appsIndex++;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            PictureBox remove = (PictureBox)sender;
            string removeElement = (string)remove.Tag.ToString().Replace("remove-", "");
            apps = removeStringElement(removeElement);
            apps_text = string.Join(";", apps);
            ini.Write("apps", apps_text);
            appsLoop();
        }

        private string[] removeStringElement(string str)
        {
            var list = new List<string>(apps);
            list.Remove(str);
            return list.ToArray();
        }

        private string[] addStringElement(string str)
        {
            var list = new List<string>(apps);
            list.Add(str);
            return list.ToArray();
        }

        private void form_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://danrotaru.github.io/?utm_source=tf");
        }

        private void radioAddApps_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string[] replaceStringElement(string search, string replace)
        {
            var list = new List<string>(apps);
            return list.Select(x => x.Replace(search, replace)).ToArray();
        }
    }
}
