using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UnRenCS
{
    public partial class Form1 : Form
    {
        private List<DirectoryInfo> gameFolders;
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
                gameFolders = new List<DirectoryInfo>();
                directories_list.Items.Clear();

                if (One.Checked)
                {
                    DirectoryInfo directory= new DirectoryInfo(folderBrowserDialog.SelectedPath);
                    gameFolders.Add(directory);
                    foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                }

                if (Many.Checked)
                {
                    string[] directories = Directory.GetDirectories(folderBrowserDialog.SelectedPath);
                    foreach (string directory in directories)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                        gameFolders.Add(directoryInfo);
                    }
                    if (by_name.Checked) gameFolders = gameFolders.OrderBy(x => x.Name).ToList();
                    if (by_date.Checked) gameFolders = gameFolders.OrderByDescending(x => x.LastWriteTime).ToList();
                    foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                }
                directories_list.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Many.Checked = true;
            by_name.Checked = true;
        }

        private void by_name_Click(object sender, EventArgs e)
        {
            if (gameFolders != null && gameFolders.Count > 0)
            {
                gameFolders = gameFolders.OrderBy(x => x.Name).ToList();
                directories_list.Items.Clear();
                foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                directories_list.SelectedIndex = 0;
            }
        }

        private void by_date_Click(object sender, EventArgs e)
        {
            if (gameFolders != null && gameFolders.Count > 0)
            {
                gameFolders = gameFolders.OrderByDescending(x => x.LastWriteTime).ToList();
                directories_list.Items.Clear();
                foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                directories_list.SelectedIndex = 0;
            }
        }
    }
}
