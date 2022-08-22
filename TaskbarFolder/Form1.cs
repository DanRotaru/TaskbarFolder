using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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


        public Form1()
        {
            
            InitializeComponent();
            //timer.Interval = 10;
            //timer.Tick += OnTimer;
            //timer.Start();

            //this.TransparencyKey = (BackColor);
            //pictureBox3.BorderStyle = BorderStyle.None;

            this.Size = new Size(355, 100);

            if (lightTheme)
            {
                BackColor = Color.FromArgb(249, 249, 249);
            }
            


            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(Cursor.Position.X - (Size.Width / 2), workingArea.Bottom - Size.Height - 10);
        }

        public int[] panelSize = { 80, 80 },
                panelLocation = { 85, 10 },
                imageLocation = { 22, 22 },
                imageSize = { 36, 36 };

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

        public void createApp(String icon = "", String path = "", String label = "", Boolean showLabels = false)
        {

            if (showLabels)
            {
                panelLocation[0] = 95;
            }

            AppN a1 = new AppN();

            int x = 10;
            for (int i = 1; i <= 4; i++)
            {
                x = x + panelLocation[0];
                if (i == 1) x = 10;

                Panel p = new Panel();
                p.Size = new Size(panelSize[0], panelSize[1]);
                p.Location = new Point(x, panelLocation[1]);
                p.Cursor = Cursors.Hand;
                p.Name = "isPanel-" + i;
                //p.Tag = path;
                p.Tag = @"D:\Software\Notepad3\Notepad3.exe";

                // Display as list view
                //p.Dock = DockStyle.Bottom;

                this.Controls.Add(p);

                PictureBox img = new PictureBox();
                Icon ico = Icon.ExtractAssociatedIcon(@"D:\Software\Notepad3\Notepad3.exe");
                img.Image = ico.ToBitmap();
                img.Location = new Point(imageLocation[0], imageLocation[1]);
                img.Enabled = false;
                img.Size = new Size(imageSize[0], imageSize[1]);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(img);

                if(showLabels)
                {
                    Label l = new Label();
                    l.Text = label;
                    l.ForeColor = Color.White;
                    l.Enabled = false;
                    l.Location = new Point(0, 50);
                    p.Controls.Add(l);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            createApp();

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

        private void clickEvent(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.Transparent;

            String path = p.Tag.ToString();

            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
                System.Windows.Forms.Application.Exit();
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
    public class AppN
    {
        public int id;
        public String name, icon, path;

        public AppN()
        {

        }
    }

    class IniFile
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
