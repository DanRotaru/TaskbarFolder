using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class Main : Form
    {
        private static readonly Helpers helpers = new Helpers();
        public static readonly IniFile ini = new IniFile("TaskbarFolder.ini");

        //public Timer timer = new Timer();
        //private int formPositionY = 0;

        public static bool 
            lightTheme = false,
            useRows = false;

        public static int rows;

        private int 
            formHeight = 130,
            panelLocationX = 10,
            appsNumber = 0,

            rowIndex = 0,
            newRowIndex = 0;

        private readonly int 
            panelSize = 80,
            imageLocation = 22,
            imageSize = 36,
            gap = 5;

        private int[] panelLocation = { 85, 40 };

        // Draggable form
        private bool 
            mouseDown, 
            continueProgram = true;

        private Point lastLocation;
        
        public static string
            theme,
            apps_text,
            min,
            ontop, 
            
            save_location,
            location_x,
            location_y,
            rows_text,
            locationChanged = "true";

        public string[] apps;

        public Main()
        {
            InitializeComponent();

            // Form shadow & border
            setTimeout(() => {
                helpers.ApplyShadows(this);
            }, 200);

            theme = ini.Read("theme");
            apps_text = ini.Read("apps");
            min = ini.Read("min");
            ontop = ini.Read("ontop");

            save_location = ini.Read("save_location");
            location_x = ini.Read("location_x");
            location_y = ini.Read("location_y");

            rows_text = ini.Read("rows");

            string ico = ini.Read("icon");
            if (!string.IsNullOrEmpty(ico))
            {
                try
                {
                    Icon = new Icon(ico);
                }
                catch (Exception)
                {
                    MessageBox.Show("This image is not valid icon!", "Error!");
                }

            }

            // There is no apps
            if (string.IsNullOrEmpty(apps_text))
            {
                AddForm form = new AddForm();
                form.Show();
                continueProgram = false;
            }
            else
                apps = apps_text.Split(';');

            // App theme (by default dark)
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

            // Put app on top
            if (string.IsNullOrEmpty(ontop))
                ini.Write("ontop", "false");

            else if (IsTrue("ontop"))
                TopMost = true;

            // Save app location
            if (string.IsNullOrEmpty(save_location))
            {
                ini.Write("save_location", "false");
                ini.Write("location_x", "0");
                ini.Write("location_y", "0");
            }

            // App rows (grid view)
            if (string.IsNullOrEmpty(rows_text))
            {
                ini.Write("rows", "0");
                rows = 0;
            }

            else if (rows_text.Equals("0"))
                useRows = false;

            else
            {
                useRows = true;
                rows = short.Parse(rows_text);
            }

            // Apps list
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!continueProgram)
                Hide();
        }

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

                panelLocation[1] = 10;
            }
            
            foreach (string app in apps)
            {
                if (!string.IsNullOrEmpty(app))
                    AddApp(app);
            }

            if (useRows && appsNumber > rows)
            {
                double rowsNum = Math.Ceiling(Convert.ToDouble(rowIndex) / Convert.ToDouble(rows));
                int marginTop = IsTrue("min") ? 15 : 45,
                    formWidth = panelSize * rows + (gap * rows) + 15;

                formHeight = (int)(marginTop + (panelSize * rowsNum) + (gap * rowsNum));

                Size = new Size(formWidth, formHeight);
            }
            else
                Size = new Size((panelLocation[0] * appsNumber) + 15, formHeight);


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
                    helpers.RoundCorners(c);
                    c.MouseEnter += PanelMouseEnter;
                    c.MouseLeave += PanelMouseLeave;
                    c.Click += ClickEvent;
                }
            }

            settingsBtn.MouseEnter += IconMouseEnter;
            settingsBtn.MouseLeave += IconMouseLeave;

            closeBtn.Location = new Point(Width - 32, 7);
            closeBtn.MouseEnter += IconMouseEnter;
            closeBtn.MouseLeave += IconMouseLeave;
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
                Location = new Point(Location.X - lastLocation.X + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
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

        public bool IsTrue(string key, bool local = false)
        {
            string value = local ? key : ini.Read(key);

            return value.Equals("true") || value.Equals("1");
        }

        public void AddApp(string app = "")
        {
            if (File.Exists(app) || app.Contains("http"))
            {
                if (useRows)
                {
                    panelLocationX = appsNumber == 0 ? 10 : panelLocationX + panelLocation[0];

                    if (rowIndex % rows == 0 && rowIndex > 0)
                    {
                        newRowIndex++;
                        panelLocationX = 10;

                        int marginTop = IsTrue("min") ? 10 : 40;
                        panelLocation[1] = marginTop + panelSize * newRowIndex + gap * newRowIndex;
                    }

                    rowIndex++;
                }

                else
                    panelLocationX = appsNumber == 0 ? 10 : panelLocationX + panelLocation[0];

                Panel p = new Panel
                {
                    Size = new Size(panelSize, panelSize),
                    Location = new Point(panelLocationX, panelLocation[1]),
                    Cursor = Cursors.Hand,
                    Name = "isPanel-" + 2,
                    Tag = @app
                };

                Controls.Add(p);

                PictureBox img = new PictureBox
                {
                    Location = new Point(imageLocation, imageLocation),
                    Enabled = false,
                    Size = new Size(imageSize, imageSize),
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

        public static void msg(string message, int line = 1)
        {
            if (line == 1)
                Console.WriteLine("----------------------\n" + message);
            else
                Console.WriteLine(message);
        }
        public static void setTimeout(Action action, int ms)
        {
            Task.Delay(ms).ContinueWith((task) =>
            {
                action();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
