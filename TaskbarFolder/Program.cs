using System;
using System.Windows.Forms;

namespace TaskbarFolder
{
    internal static class Program
    {
        static readonly IniFile ini = new IniFile("TaskbarFolder.ini");

        [STAThread]
        static void Main(string[] args)
        {
            
            string apps_text = ini.Read("apps");

            if(args.Length != 0) MessageBox.Show(args[0].ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (string.IsNullOrEmpty(apps_text))
                Application.Run(new AddForm());
            else
                Application.Run(new Main());
        }
    }
}
