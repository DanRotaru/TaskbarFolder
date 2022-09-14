using System;
using System.Windows.Forms;

namespace TaskbarFolder
{
    internal static class Program
    {
        static readonly IniFile ini = new IniFile("TaskbarFolder.ini");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string apps_text = ini.Read("apps");

            if (string.IsNullOrEmpty(apps_text))
                Application.Run(new AddForm());
            else
                Application.Run(new Main());
        }
    }
}
