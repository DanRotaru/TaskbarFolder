using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //public Timer timer = new Timer();
        public int formPositionY = 0;

        // Dark/light theme
        public static bool lightTheme = false;

        // Form size
        public int formHeight = 130,
            panelLocationX = 10,
            appsNumber = 0;

        public int[] panelSize = { 80, 80 },
                panelLocation = { 85, 40 },
                imageLocation = { 22, 22 },
                imageSize = { 36, 36 };

        public int columnIndex = 0, gap = 5;
        public static int columns;
        public static bool useColumns = false;

        // Draggable form
        private bool mouseDown, continueProgram = true;
        private Point lastLocation;
       
        public IniFile ini = new IniFile("TaskbarFolder.ini");
        public static string
            theme,
            apps_text,
            min,
            ontop, 
            
            save_location,
            location_x,
            location_y,
            columns_text,
            locationChanged = "true";

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!continueProgram)
                Hide();
        }

        public string[] apps;

        public Form1()
        {
            
            InitializeComponent();

            theme = ini.Read("theme");
            apps_text = ini.Read("apps");
            min = ini.Read("min");
            ontop = ini.Read("ontop");

            save_location = ini.Read("save_location");
            location_x = ini.Read("location_x");
            location_y = ini.Read("location_y");

            columns_text = ini.Read("columns");

            // There is no apps
            if (string.IsNullOrEmpty(apps_text))
            {
                Form2 form2 = new Form2();
                Rectangle workingArea = Screen.GetWorkingArea(this);
                form2.Location = new Point(workingArea.Width / 2 - 312, workingArea.Height / 2 - 262);
                form2.Show();
                continueProgram = false;
            }
            else
                apps = apps_text.Split(';');

            // Initial theme (by default dark)
            if (string.IsNullOrEmpty(theme)) 
                ini.Write("theme", "dark");

            else if(theme == "light" || theme == "1")
            {
                lightTheme = true;
                BackColor = Color.FromArgb(249, 249, 249);
            }

            // Minimal view
            if (string.IsNullOrEmpty(min))
                ini.Write("min", "false");

            // App on top
            if (string.IsNullOrEmpty(ontop))
                ini.Write("ontop", "false");

            else if (IsTrue("ontop"))
                TopMost = true;

            if (string.IsNullOrEmpty(save_location))
            {
                ini.Write("save_location", "false");
                ini.Write("location_x", "0");
                ini.Write("location_y", "0");
            }

            // App columns (grid view)
            if (string.IsNullOrEmpty(columns_text))
            {
                ini.Write("columns", "0");
                columns = 0;
            }
            else if (columns_text.Equals("0"))
                useColumns = false;
            else
            {
                useColumns = true;
                columns = short.Parse(columns_text);
            }

            if (string.IsNullOrEmpty(apps_text))
                ini.Write("apps", "");
        }

        /*private void OnTimer(Object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Location = new Point(Location.X, formPositionY);
            formPositionY -= 50;
            if (formPositionY <= workingArea.Bottom - Size.Height - 10)
            {
                timer.Stop();
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            if (apps == null)
                return;

            // Minimalistic view
            if (IsTrue("min"))
            {
                closeBtn.Visible = false;
                settingsBtn.Visible = false;


                formHeight = 100;
                Size = new Size(Size.Width, formHeight);

                //panelLocation[1] = 10;
            }
            
            foreach (string app in apps)
            {
                if (!string.IsNullOrEmpty(app))
                {
                    CreateApp(app);
                }
            }

            if (useColumns)
            {
                formHeight = (panelSize[1] * columnIndex + 45 + (gap * columnIndex));

                Console.WriteLine(columnIndex);
                int x;

                if (IsTrue("min"))
                    x = panelSize[1] * (appsNumber - columnIndex) + 40;
                else
                    x = panelSize[1] * (appsNumber - columnIndex) + 40;
                
                x = panelSize[0] * columns + (gap * columns) + 15;
                Console.WriteLine(x);

                Size = new Size(x, formHeight);
            }
            else
                Size = new Size((panelLocation[0] * appsNumber) + 15, formHeight);



            //Size = new Size(1200, 1000);
            RoundCorners(this);

            //timer.Interval = 10;
            //timer.Tick += OnTimer;
            //timer.Start();

            if (IsTrue("save_location") &&
                !string.IsNullOrEmpty(location_x) &&
                !string.IsNullOrEmpty(location_y))
            {
                int x = Convert.ToInt16(location_x), 
                    y = Convert.ToInt16(location_y);
                Location = new Point(x, y);
            }
            else
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                Location = new Point(Cursor.Position.X - (Size.Width / 2), workingArea.Height - Height - 10);
            }

            foreach (Control c in Controls)
            {
                if (c is Panel)
                {
                    RoundCorners(c);
                    c.MouseEnter += PanelMouseEnter;
                    c.MouseLeave += PanelMouseLeave;
                    c.Click += ClickEvent;
                }
            }

            closeBtn.Location = new Point(Width - 30, 7);

            settingsBtn.MouseEnter += IconMouseEnter;
            settingsBtn.MouseLeave += IconMouseLeave;

            closeBtn.MouseEnter += IconMouseEnter;
            closeBtn.MouseLeave += IconMouseLeave;
            RoundCorners(closeBtn);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsTrue("save_location") && !string.IsNullOrEmpty(locationChanged))
            {
                Point p = new Point(Location.X, Location.Y);
                ini.Write("location_x", p.X.ToString());
                ini.Write("location_y", p.Y.ToString());
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {

            if ((Application.OpenForms["SettingsForm"] as SettingsForm) != null)
            {
                //Form is already open
            }
            else
            {
                SettingsForm form = new SettingsForm();
                Rectangle workingArea = Screen.GetWorkingArea(this);
                form.Location = new Point(workingArea.Width / 2 - 220, workingArea.Height / 2 - 335);
                form.Show();
            }

            
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.Transparent;

            string path = p.Tag.ToString();

            if (path.StartsWith("http") || File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
                Application.Exit();
            }

            else
            {
                MessageBox.Show("File " + path + " not exists!", "Error!");
            }

        }


        private void PanelMouseEnter(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p.Name.Contains("isPanel"))
            {
                if (lightTheme)
                {
                    p.BackColor = Color.FromArgb(230, 230, 230);
                } 
                else
                {
                    p.BackColor = Color.FromArgb(45, 45, 45);
                }
            }
        }

        private void PanelMouseLeave(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p.Name.Contains("isPanel"))
            {
                p.BackColor = Color.Transparent;
            }
            
        }

        private void IconMouseEnter(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p.Name.Equals("closeBtn"))
            {
                //closeBtn.BackColor = Color.Red;

                _ = lightTheme
                    ? closeBtn.Image = Properties.Resources.closeHoverLight
                    : closeBtn.Image = Properties.Resources.closeHover;
            }
            else if (p.Name.Equals("settingsBtn"))
            {
                _ = lightTheme
                    ? settingsBtn.Image = Properties.Resources.settingsHoverLight
                    : settingsBtn.Image = Properties.Resources.settingsHover;
            }
        }

        private void IconMouseLeave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p.Name.Equals("closeBtn"))
            {
                closeBtn.Image = Properties.Resources.close;
            }
            else if (p.Name.Equals("settingsBtn"))
            {
                settingsBtn.Image = Properties.Resources.settings;
            }
        }

        public static Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        public bool IsTrue(string key)
        {
            string value = ini.Read(key);
            if (value.Equals("true") || value.Equals("1"))
                return true;
            else
                return false;
        }

        public void RoundCorners(Control el, int radius = 10)
        {
            el.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, el.Width, el.Height, radius, radius));
        }

        
        public void CreateApp(string app = "")
        {
            //350 / (80 - 10)
            /* public int formHeight = 130,
                panelLocationX = 10,
                appsNumber = 0;

                public int[] panelSize = { 80, 80 },
                    panelLocation = { 85, 40 },
                    imageLocation = { 22, 22 },
                    imageSize = { 36, 36 };
                */

            //Console.WriteLine(panelLocationX - panelSize[0] - 10);

            if (File.Exists(app) || app.Contains("http"))
            {

                Panel p = new Panel
                {
                    Size = new Size(panelSize[0], panelSize[1]),
                    Location = new Point(panelLocationX, panelLocation[1]),
                    Cursor = Cursors.Hand,
                    Name = "isPanel-" + 2,
                    Tag = @app
                };

                if (useColumns && appsNumber % columns == 0)
                {
                    //Console.WriteLine(columnIndex + ". " + appsNumber + " " + app);

                    panelLocationX = 10;
                    if (columnIndex == 0)
                        panelLocation[1] = 40;
                    else
                        panelLocation[1] = 40 + panelSize[1] * columnIndex + (columnIndex * gap);

                    columnIndex++;
                }
                else
                {
                    panelLocationX += panelLocation[0];
                }



                // Display as list view
                //p.Dock = DockStyle.Bottom;

                this.Controls.Add(p);


                PictureBox img = new PictureBox
                {
                    Location = new Point(imageLocation[0], imageLocation[1]),
                    Enabled = false,
                    Size = new Size(imageSize[0], imageSize[1]),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (app.StartsWith("http"))
                {
                    _ = lightTheme
                        ? img.Image = Properties.Resources.web
                        : img.Image = Properties.Resources.webLight;
                }
                else
                {
                    Icon ico = Icon.ExtractAssociatedIcon(@app);
                    img.Image = ico.ToBitmap();
                }

                p.Controls.Add(img);
                appsNumber++;
            }
        }
    }
}
