using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UnRenC;

namespace UnRenCS
{
    public partial class Form1 : Form
    {
        private List<DirectoryInfo> gameFolders;
        private readonly ExecuteCommands executeCommands = new ExecuteCommands();
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the window?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) e.Cancel = true;
        }

        private void Open_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                gameFolders = new List<DirectoryInfo>();
                directories_list.Items.Clear();

                if (One.Checked)
                {
                    DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                    if (directory.GetDirectories("renpy").Length > 0)
                    {
                        gameFolders.Add(directory);
                        foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                        directories_list.SelectedIndex = 0;
                    }
                    else console_log.Text += "This game is not based on the RenPy engine. Choose another one";
                }

                if (Many.Checked)
                {
                    DirectoryInfo[] directories = new DirectoryInfo(folderBrowserDialog.SelectedPath).GetDirectories();
                    foreach (DirectoryInfo subdirectory in directories)
                    {
                        if (subdirectory.GetDirectories("renpy").Length > 0) gameFolders.Add(subdirectory);
                    }
                    if (by_name.Checked) gameFolders = gameFolders.OrderBy(x => x.Name).ToList();
                    if (by_date.Checked) gameFolders = gameFolders.OrderByDescending(x => x.LastWriteTime).ToList();
                    foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                    directories_list.SelectedIndex = 0;
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Many.Checked = true;
            by_name.Checked = true;
        }

        private void By_name_Click(object sender, EventArgs e)
        {
            if (gameFolders != null && gameFolders.Count > 0)
            {
                gameFolders = gameFolders.OrderBy(x => x.Name).ToList();
                directories_list.Items.Clear();
                foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                directories_list.SelectedIndex = 0;
            }
        }

        private void By_date_Click(object sender, EventArgs e)
        {
            if (gameFolders != null && gameFolders.Count > 0)
            {
                gameFolders = gameFolders.OrderByDescending(x => x.LastWriteTime).ToList();
                directories_list.Items.Clear();
                foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                directories_list.SelectedIndex = 0;
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (gameFolders == null || gameFolders.Count == 0)
            {
                MessageBox.Show("The list of games is empty! First, open the games folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                executeCommands.Execute(gameFolders.Select(x => x).Where(x => x.Name == directories_list.SelectedItem.ToString()).First(), new List<bool>() { true });
            }
        }
    }
}
