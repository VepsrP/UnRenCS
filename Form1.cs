using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace UnRenCS
{
    public partial class Form1 : Form
    {
        private List<GameFolder> gameFolders;
        private GameFolder gameFolder;
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the window?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) e.Cancel = true;
        }

        private void open_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                gameFolders = new List<GameFolder>();
                directories_list.Items.Clear();

                if (One.Checked)
                {
                    DirectoryInfo directory= new DirectoryInfo(folderBrowserDialog.SelectedPath);
                    gameFolder.Name = directory.Name;
                    gameFolder.ChangeDate = directory.LastWriteTime;
                }

                if (Many.Checked)
                {
                    string[] directories = Directory.GetDirectories(folderBrowserDialog.SelectedPath);
                    foreach (string directory in directories)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                        gameFolders.Add(new GameFolder(directoryInfo.Name, directoryInfo.LastWriteTime));
                    }
                    if (by_name.Checked) gameFolders = gameFolders.OrderBy(x => x.Name).ToList();
                    if (by_date.Checked) gameFolders = gameFolders.OrderByDescending(x => x.ChangeDate).ToList();
                    foreach (GameFolder gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Many.Checked = true;
            by_name.Checked = true;
        }
    }
}
