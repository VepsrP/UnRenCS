using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

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

        private void ConsoleLogUpdate(string message)
        {
            console_log.AppendText(message);
            console_log.SelectionStart = console_log.Text.Length;
            console_log.ScrollToCaret();
            Thread.Sleep(75);
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (executeCommands.Executed == true)
            {
                e.Cancel = true;
                MessageBox.Show("Not possible to close before the end of commands!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure you want to close the window?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) e.Cancel = true;

            else
            {
                //One or many games folder selected
                if (One.Checked) UnRenSettings.Default["Amount"] = One.Name;
                if (Many.Checked) UnRenSettings.Default["Amount"] = Many.Name;

                //Sorting
                if (By_Name.Checked) UnRenSettings.Default.Sorting = By_Name.Name;
                if (By_Date.Checked) UnRenSettings.Default.Sorting = By_Date.Name;

                //Executable commands
                UnRenSettings.Default.Unpacking = Unpacking.Checked;
                UnRenSettings.Default.Decompile = Decompile.Checked;
                UnRenSettings.Default.Console = Console.Checked;
                UnRenSettings.Default.Quick_menu = Quick_menu.Checked;
                UnRenSettings.Default.Skipping = Skipping.Checked;
                UnRenSettings.Default.Rollback = Rollback.Checked;

                //Decompiler options
                UnRenSettings.Default.Overwrite = Overwrite.Checked;
                UnRenSettings.Default.Deobfuscation = Deobfuscation.Checked;
                UnRenSettings.Default.Dump = Dump.Checked;

                //Unpaking options
                UnRenSettings.Default.Delarchives = Delarchives.Checked;

                UnRenSettings.Default.Save();
            }
        }

        private void Open_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) Directories_Fill(folderBrowserDialog.SelectedPath);
        }

        private void Directories_Fill(string SelectedPath)
        {
            gameFolders = new List<DirectoryInfo>();
            directories_list.Items.Clear();

            if (One.Checked)
            {
                DirectoryInfo directory = new DirectoryInfo(SelectedPath);
                if (directory.GetDirectories("renpy").Length > 0)
                {
                    UnRenSettings.Default.SelectedPath = SelectedPath;
                    gameFolders.Add(directory);
                    foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                    directories_list.SelectedIndex = 0;
                    UnRenSettings.Default.SelectedPath = SelectedPath;
                    return;
                }
                console_log.Text += "This folder not have game based on the RenPy engine. Choose another one";
                UnRenSettings.Default.SelectedPath = "";
            }

            if (Many.Checked)
            {
                DirectoryInfo[] directories = new DirectoryInfo(SelectedPath).GetDirectories();
                foreach (DirectoryInfo subdirectory in directories)
                {
                    if (subdirectory.GetDirectories("renpy").Length > 0) gameFolders.Add(subdirectory);
                }
                if (!gameFolders.Any())
                {
                    console_log.Text += "This folder not have games based on the RenPy engine. Choose another one";
                    UnRenSettings.Default.SelectedPath = "";
                    return;
                }
                if (By_Name.Checked) gameFolders = gameFolders.OrderBy(x => x.Name).ToList();
                if (By_Date.Checked) gameFolders = gameFolders.OrderByDescending(x => x.LastWriteTime).ToList();
                foreach (DirectoryInfo gameFolder in gameFolders) directories_list.Items.Add(gameFolder.Name);
                directories_list.SelectedIndex = 0;
                UnRenSettings.Default.SelectedPath = SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //One or many games folder selected
            ((RadioButton)groupBox4.Controls[UnRenSettings.Default.Amount]).Checked = true;

            //Sorting
            ((RadioButton)groupBox3.Controls[UnRenSettings.Default.Sorting]).Checked = true;

            //Executable commands
            Unpacking.Checked = UnRenSettings.Default.Unpacking;
            Decompile.Checked = UnRenSettings.Default.Decompile;
            Console.Checked = UnRenSettings.Default.Console;
            Quick_menu.Checked = UnRenSettings.Default.Quick_menu;
            Skipping.Checked = UnRenSettings.Default.Skipping;
            Rollback.Checked = UnRenSettings.Default.Rollback;

            //Decompiler options
            Overwrite.Checked = UnRenSettings.Default.Overwrite;
            Deobfuscation.Checked = UnRenSettings.Default.Deobfuscation;
            Dump.Checked = UnRenSettings.Default.Dump;

            //Unpaking options
            Delarchives.Checked = UnRenSettings.Default.Delarchives;

            //Fill directories
            if (UnRenSettings.Default.SelectedPath != "") Directories_Fill(UnRenSettings.Default.SelectedPath);
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
                Commands commands = new Commands
                {
                    Rollback = Rollback.Checked,
                    Skip = Skipping.Checked,
                    Quick = Quick_menu.Checked,
                    Decompile = Decompile.Checked,
                    Unpack = Unpacking.Checked,
                    Console = Console.Checked,
                    Delarchives = Delarchives.Checked,
                    OverWrite = Overwrite.Checked,
                    Deobfuscation = Deobfuscation.Checked,
                    Dump = Dump.Checked
                };

                //var progress = new Progress<string>(s => console_log.Text += s);
                var progress = new Progress<string>(ConsoleLogUpdate);
                var directory = gameFolders.Select(x => x).Where(x => x.Name == directories_list.SelectedItem.ToString()).First();

                Thread executeThread = new Thread(() => executeCommands.Execute(directory, commands, progress));
                executeThread.Start();
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (UnRenSettings.Default.Amount == "Many")
            {
                directories_list.Items.Clear();
                UnRenSettings.Default.Amount = "One";
            }
        }

        private void Many_Click(object sender, EventArgs e)
        {
            if (UnRenSettings.Default.Amount == "One")
            {
                directories_list.Items.Clear();
                UnRenSettings.Default.Amount = "Many";
            }
        }
    }
}
