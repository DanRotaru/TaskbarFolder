using System;
using System.Windows.Forms;

namespace TaskbarFolder
{
    
    public partial class Form2 : Form
    {

        public IniFile ini = new IniFile("TaskbarFolder.ini");

        public Form2()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form2_DragEnter);
            DragDrop += new DragEventHandler(Form2_DragDrop);
        }


        void Form2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            loadFile(files);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
    }
}
