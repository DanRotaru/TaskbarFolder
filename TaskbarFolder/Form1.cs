using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TaskbarFolder
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //public Timer timer = new Timer();
        public int formPositionY = 0;

        // Dark/light theme
        public bool lightTheme = false;

        // Form size
        public int formHeight = 100;

        public int[] panelSize = { 80, 80 },
                panelLocation = { 85, 10 },
                imageLocation = { 22, 22 },
                imageSize = { 36, 36 };

        public int x = 10;

        // Draggable
        private bool mouseDown;
        private Point lastLocation;

        public IniFile ini = new IniFile();

        public Form1()
        {
            
            InitializeComponent();

            // If is not apps
            if (!ini.KeyExists("apps"))
            {
                var form2 = new Form2();
                form2.Show();
            }

            // Initial theme
            if (!ini.KeyExists("theme"))
            {
                ini.Write("theme", "dark");
            }

            String theme = ini.Read("theme");

            if (theme == "light") lightTheme = true;
            if (lightTheme) BackColor = Color.FromArgb(249, 249, 249);

            //timer.Interval = 10;
            //timer.Tick += OnTimer;
            //timer.Start();

            String save_location = ini.Read("save_location");

            if ((ini.KeyExists("save_location") && save_location == "true") && ini.KeyExists("location_x") && ini.KeyExists("location_y"))
            {
                
                int x = Convert.ToInt16(ini.Read("location_x"));
                int y = Convert.ToInt16(ini.Read("location_y"));
                this.Location = new Point(x, y);
                MessageBox.Show(x.ToString() + " " + y.ToString());
                Console.Write(x);
                Console.Write(y);
            }
            else
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                this.Location = new Point(Cursor.Position.X - (Size.Width / 2), workingArea.Bottom - Size.Height - 10);
            }

            string[] apps = @ini.Read("apps").Split(';');
            
            int n = 0;
            foreach (String app in apps)
            {
                Console.WriteLine(n);
                Console.WriteLine(app);
                createApp(app);
                n++;
            }
            this.Size = new Size((panelLocation[0] * n) + 15, formHeight);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
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

        public void createApp(String app = "")
        {
            if (File.Exists(app))
            {
                //String icon = "", String path = "", String label = "", Boolean showLabels = false
                Boolean showLabels = false;

                if (showLabels)
                {
                    panelLocation[0] = 95;
                }


                Panel p = new Panel();
                p.Size = new Size(panelSize[0], panelSize[1]);
                p.Location = new Point(x, panelLocation[1]);
                p.Cursor = Cursors.Hand;
                p.Name = "isPanel-" + 2;
                //p.Tag = path;
                p.Tag = @app;

                // Display as list view
                //p.Dock = DockStyle.Bottom;

                this.Controls.Add(p);

                PictureBox img = new PictureBox();
                Icon ico = Icon.ExtractAssociatedIcon(@app);
                img.Image = ico.ToBitmap();
                img.Location = new Point(imageLocation[0], imageLocation[1]);
                img.Enabled = false;
                img.Size = new Size(imageSize[0], imageSize[1]);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(img);

                x += panelLocation[0];

                if (showLabels)
                {
                    Label l = new Label();
                    //l.Text = label;
                    l.ForeColor = Color.White;
                    l.Enabled = false;
                    l.Location = new Point(0, 50);
                    p.Controls.Add(l);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, 10, 10));
                    c.MouseEnter += panelMouseEnter;
                    c.MouseLeave += panelMouseLeave;
                    c.Click += clickEvent;
                }
            }
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
                this.Location = new Point(
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
            String save_location = ini.Read("save_location");
            if (ini.KeyExists("save_location") && save_location == "true")
            {
                Point p = new Point(this.Location.X, this.Location.Y);
                ini.Write("location_x", p.X.ToString());
                ini.Write("location_y", p.Y.ToString());
            }
        }

        private void clickEvent(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.Transparent;

            String path = p.Tag.ToString();

            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
                Application.Exit();
            } 
            else
            {
                MessageBox.Show("File " + path + " not exists!", "Error!");
            }

        }


        private void panelMouseEnter(object sender, EventArgs e)
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

        private void panelMouseLeave(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p.Name.Contains("isPanel"))
            {
                p.BackColor = Color.Transparent;
            }
            
        }
    }

    public class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
