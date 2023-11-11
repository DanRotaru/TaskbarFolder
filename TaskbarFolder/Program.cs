using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskbarFolder
{
    internal static class Program
    {
        static readonly IniFile ini = new IniFile("TaskbarFolder.ini");

        /*
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
        */

        [STAThread]
        static void Main()
        {
            var currentProcess = Process.GetCurrentProcess();

            // search for another process with the same name
            var applicationIsRunning = Process.GetProcesses().FirstOrDefault(p => p.ProcessName == currentProcess.ProcessName && p.Id != currentProcess.Id);

            if (applicationIsRunning != null)
            {
                //ShowWindow(anotherProcess.MainWindowHandle, 5);
                //Application.Run(mainForm);
                //Application.OpenForms["Main"].Show();
                return; // don't continue to run your application.
            }

            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string apps_text = ini.Read("apps");

            if (string.IsNullOrEmpty(apps_text))
                //Application.Run(new AddForm());
                Application.Run(new AddForm());
            else
            {
                Form main = new Main();
                //Form main = new AddForm(); // to show always addForm
                Application.Run(main);
                
                if (Properties.Settings.Default.IsRestarting is true)
                    Application.Restart();
            }

            if (Properties.Settings.Default.Exiting is true)
                Application.Exit();
        }


        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

    }
}
