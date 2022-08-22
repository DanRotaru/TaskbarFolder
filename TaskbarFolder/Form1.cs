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

        public IniFile ini = new IniFile("TaskbarFolder.ini");

        public Form1()
        {
            
            InitializeComponent();

            // If is not apps
            if (!ini.KeyExists("apps"))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

            // Initial theme
            if (!ini.KeyExists("theme"))
            {
                ini.Write("theme", "dark");
            }

            string theme = ini.Read("theme");

            if (theme == "light") lightTheme = true;
            if (lightTheme) BackColor = Color.FromArgb(249, 249, 249);

            //timer.Interval = 10;
            //timer.Tick += OnTimer;
            //timer.Start();

            string save_location = ini.Read("save_location");

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
            foreach (string app in apps)
            {
                if (!app.Equals(""))
                {
                    createApp(app);
                    n++;
                }
                
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

        public void createApp(string app = "")
        {
            if (File.Exists(app) || app.Contains("http"))
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
                if (app.StartsWith("http"))
                {
                    string light_base64 = "iVBORw0KGgoAAAANSUhEUgAAACQAAAAkCAYAAADhAJiYAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAABmJLR0QAAAAAAAD5Q7t/AAAACXBIWXMAAABgAAAAYADwa0LPAAACkklEQVRYw+2Yz2tTQRDHP0lB0pPGVi/WiwUFFW9eRI8iaCFI6lUQ/wOrAY9qcxAESz0ISs+tSBQPVlDUUy16FT1ZoUVrtGr12mrj4e0j37fd7L4kbUTpwJLJfN/Mft/O/ph9sCH/mGRa8NkEHAOOAgeBXUDeYIvAe2AKeAC8AH6vF/luoAQsALWU7bPx6V5rMoPAXBNE7DZnYrQtWWAYWLE6+ESUivj/E9Pi/7+AquWzApRNzJbJjFtBPwCngYLYloC9pi2JfQA4A8xbMSZaJTVsBbpDffI+F/t18RkR+2Nj6wEqVqxys2SKVppuUl+R+63U7BC/PmOL8T0y2ret9BXTksmRnMB3SW4PlwR76PCfFPyi2DPAPZITPZeGUEmcPpohV3kruGvlDAr+ysLy1suWQmS6WL061rNVTZ8N5UgHycTtsBKwl18hTU7XWLx9Tgvz4w78huDnPHGG5LlRB35C8CnfCPWL/toRKC/6Vw+hBdG3OnCNrX2uIrS5QdBYegK4i6yL0BfRt/gIhaQmuq90yTTwCfZrAz9F3+Z4/rvovR5COpKLDlx9f/gIzYh+IEDIRTiW7aJ/c+Aa+50nDtfo/D501Ufob2yMh3yEuojKzk4eHcGFFTpc3wjuOlxPCf7SwuzDdShEBqKCXJ0qNC4/Jh3+jwTX8iML3BdslpTlB+bNtUC7JUNrF2h94reTZIG2W8iMiX0FOJmWTCxlkvmuUE/fM7GPiM+o2OMSttcamRpwuVky8VtNWIHmiQp3LfKXgX1m5JbFPgCcJbqhaIxx2rx5lAlfg56aFroGXWmHjEqR9i6Ks7QwZ0KSAy7QXIlbBc7TxGpq5WNDlmh3LZjffpIfG2aof2yYJkrVhvy/8gf4rqhW//b74AAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAyMi0wOC0yMlQyMzoxNDowNSswMDowML4I/y0AAAAldEVYdGRhdGU6bW9kaWZ5ADIwMjItMDgtMjJUMjM6MTQ6MDUrMDA6MDDPVUeRAAAAAElFTkSuQmCC";
                    string dark_base64 = "iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAABmJLR0QAAAAAAAD5Q7t/AAAACXBIWXMAAABgAAAAYADwa0LPAAADwElEQVRo3u2Zy29NURTGv9OodyXUu6qtECMTGvGIgce/IC1DJgbMRMOAIlHBzPMfMEVSj8RAwoBECBMSklK3HtF6JS4qys/gnMrJOvuce869p65Hv+QO9t7fWftba5+7z15rS6MYxf8NLw8jQI2k5ZLWSlomabGkBkmTgjmKkl5KeiTprqRrkm57nvejqt4DDUAX0Ed29AXPzquG8HrgFDBYhnCLr8BpYPrvEt8ODOQg3OIN0D6SwscEkYrDkKPvMnAlJXcYZ4DavMVPALpjJnwG7ASOmv6PQBPQDBTN2GGgA3geY/MSMDHPyLvEfwM6gdrAwddmfG/IRqcZewGMA8YCh2JW5GIuKxHz2vQArSHONjP+GqgLjdcB/YazNTS+Auh1zHO6UvFtDqOPMVsf8DAu+iHOPsO5b8bnB4GxaCtXfD3R3aYHmGt4SwznCzDTYW8W0W13keE0OlZiAKgvx4FTxtA3YIWDt9/wziXYPG+4uxyc1UT/Eyezip+H/4EJozOGa1+f9gS7mwz3VgzvoOF9BeZncaCLPw9dLq2eQ3yNpF5JjZmWbeTxQlKT53nfw501DuLyP1C85J9ul9lOlwNrq600AevSONBq2tu9GEi6YbjrvRKQtME8cz2Bu8NwU63AYtO+lxCRqaZdSBHFPtOelsC1c1ttTgfmmPaThAnsB2YghQNvMjjwtIQ2pwOTTftDwgR28s8pHCiWCEIY70y7zhJqVBmo8HlJSsqLS+pzEWyEpiY8byOU5gw/uYSNpLk/pnHglWm3ZHBgRgoHbO77PoHbXEKb04HHpr00gwNpziuW8zaBa+d+VNI6sKfah54EdKRZgWspolgtRLT9TYe5gqQWW82LrEBAOFtttQ6cTV2KxJ3QHIjhPjC8TQl2NxvuzRieTWgGgYZM7hKtRgwBqxy8LCnlBcN1pZRriKaUxzOvFzAdv9wXxlOg0fBsUj8IzHLYm+1Y1YWG0wQUDKcfmFZKb5wT7Y6trAeTnxLNi/c5bNni1j0z3hwEyGJjWeJDhs84jPYCK0McW9jqB6aExqcQLdFsCY2vdkQe4ERF4gPjtfi1Sosh/LLgONylxf0hG/ZPOVxaHA8cwV1a7AbGVOxAIGBijBPgF2g7gGOmvwi0AAuAT2bsMLAbeBljs5u8irtmJbKW168GvzTcX69NbpGPcaSNkbng6KfSP2wGJ+qBk+RzxTQIHKfcrbJCR4Yv+QplCC/gbwLZvrAGeV6ztsqv24SvWYezr6Kk5/JzjTvyT5V3q37NOopR/AP4CQvsiBRMMmAcAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDIyLTA4LTIyVDIzOjIzOjI5KzAwOjAwQLPvXAAAACV0RVh0ZGF0ZTptb2RpZnkAMjAyMi0wOC0yMlQyMzoyMzoyOSswMDowMDHuV+AAAAAASUVORK5CYII=";
                    
                    if(lightTheme)
                    {
                        img.Image = ConvertBase64ToImage(light_base64);
                    }
                    else
                    {
                        img.Image = ConvertBase64ToImage(dark_base64);
                    }
                }
                else
                {
                    Icon ico = Icon.ExtractAssociatedIcon(@app);
                    img.Image = ico.ToBitmap();
                }
                
                
                
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
            string save_location = ini.Read("save_location");
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

        public Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
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
