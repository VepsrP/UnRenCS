using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UnRenCS
{
    internal class ExecuteCommands : IExecuteCommands
    {
        private string python = "";
        private IProgress<string> progress;
        public string Execute(DirectoryInfo directory, Commands commands, IProgress<string> progress)
        {
            if (directory.GetDirectories("lib\\windows-x86_64").Length > 0) python = directory.GetDirectories("lib\\windows-x86_64")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\windows-i686").Length > 0) python =  directory.GetDirectories("lib\\windows-i686")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\py2-windows-i686").Length > 0) python =  directory.GetDirectories("lib\\py2-windows-i686")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\py2-windows-x86_64").Length > 0) python =  directory.GetDirectories("lib\\py2-windows-x86_64")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\py3-windows-x86_64").Length > 0) python =  directory.GetDirectories("lib\\py3-windows-x86_64")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\pythonlib2.7").Length > 0) python += " -O";

            this.progress = progress;

            if (commands.Unpack) UnpackCommand(directory, python, commands.Delarchives);
            if (commands.Decompile) DecompileCommand(directory, python);

            if (commands.Console) ConsoleCommand(directory);
            if (commands.Quick) QuickCommand(directory);
            if (commands.Skip) SkipCommand(directory);
            if (commands.Rollback) RollbackCommand(directory);

            return "All commands is executed!";
        }

        private void UnpackCommand(DirectoryInfo directory, string python, bool Delarchives)
        {
            using (StreamWriter unpackWrite = new StreamWriter(directory.FullName + "\\rpatool.rpy"))
            {
                unpackWrite.Write(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.unpackCode)));
            }
            string args = directory.FullName + "\\rpatool.rpy ";
            args += directory.FullName + "\\game";
            if (Delarchives) args += " -r";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = directory.FullName + "\\game";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.ErrorDialog = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.Arguments ="/C " + python + " " + args;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    progress.Report(e.Data+"\n");
                }
            });

            process.Start();
            process.BeginOutputReadLine();
        }

        private void DecompileCommand(DirectoryInfo directory, string python)
        {
            using (StreamWriter unpackWrite = new StreamWriter(directory.FullName + "\\rpatool.rpy"))
            {
                unpackWrite.Write(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.unpackCode)));
            }
            Process.Start(directory.FullName + "\\", "");
        }

        private void ConsoleCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-console.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.consoleCode)));
            }
        }
        private void QuickCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-quick.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.quickCode)));
            }
        }
        private void SkipCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-skip.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.skipCode)));
            }
        }
        private void RollbackCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-rollback.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.rollbackCode)));
            }
        }
    }
}
