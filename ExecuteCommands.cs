using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;

namespace UnRenCS
{
    internal class ExecuteCommands : IExecuteCommands
    {
        private string python = "";
        private IProgress<string> progress;
        private bool executed = false;
        public bool Executed => executed;

        public void Execute(DirectoryInfo directory, Commands commands, IProgress<string> progress)
        {
            if (directory.GetDirectories("lib\\windows-x86_64").Length > 0) python = directory.GetDirectories("lib\\windows-x86_64")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\windows-i686").Length > 0) python =  directory.GetDirectories("lib\\windows-i686")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\py2-windows-i686").Length > 0) python =  directory.GetDirectories("lib\\py2-windows-i686")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\py2-windows-x86_64").Length > 0) python =  directory.GetDirectories("lib\\py2-windows-x86_64")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\py3-windows-x86_64").Length > 0) python =  directory.GetDirectories("lib\\py3-windows-x86_64")[0].FullName + "\\python.exe";
            if (directory.GetDirectories("lib\\pythonlib2.7").Length > 0) python += " -O";

            this.progress = progress;

            if (commands.Unpack)
            {
                UnpackCommand(directory, python, commands.Delarchives);
            }
            if (commands.Decompile) DecompileCommand(directory, python, commands.OverWrite, commands.Deobfuscation, commands.Dump);

            if (commands.Console) ConsoleCommand(directory);
            if (commands.Quick) QuickCommand(directory);
            if (commands.Skip) SkipCommand(directory);
            if (commands.Rollback) RollbackCommand(directory);
        }

        private void UnpackCommand(DirectoryInfo directory, string python, bool Delarchives)
        {
            using (StreamWriter unpackWrite = new StreamWriter(directory.FullName + "\\rpatool.rpy"))
            {
                unpackWrite.Write(Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.unpackCode)));
            }
            string args = directory.FullName + "\\rpatool.rpy ";
            args += directory.FullName + "\\game";
            if (Delarchives) args += " -r";
            Process process = new Process();
            process.StartInfo.FileName = python;
            process.StartInfo.WorkingDirectory = directory.FullName + "\\game";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.ErrorDialog = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.Arguments = args;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    progress.Report(e.Data+"\n");
                }
            });
            process.EnableRaisingEvents = true;
            process.Exited += (s, ea) =>
            {
                File.Delete(directory.FullName + "\\rpatool.rpy");
                executed = false;
            };
            executed = true;
            process.Start();
            process.BeginOutputReadLine();
            while (process.HasExited == false)
                Thread.Sleep(100);
                
        }

        private void DecompileCommand(DirectoryInfo directory, string python, bool OverWrite, bool Deobfuscation, bool Dump)
        {
            byte[] bytes = Convert.FromBase64String(Base64Codes.decompileCode);
            File.WriteAllBytes(directory.FullName + "\\unrpyc.zip", bytes);
            ZipFile.ExtractToDirectory(directory.FullName + "\\unrpyc.zip", directory.FullName);

            string args = directory.FullName + "\\unrpyc.py ";
            args += directory.FullName + "\\game";
            if (OverWrite) args += " -c";
            if (Deobfuscation) args += " --try-harder";
            if (Dump) args += " -d";
            Process process = new Process();
            process.StartInfo.FileName = python;
            process.StartInfo.WorkingDirectory = directory.FullName + "\\game";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.ErrorDialog = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.Arguments = args;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    progress.Report(e.Data + "\n");
                }
            });
            process.EnableRaisingEvents = true;
            process.Exited += (s, ea) =>
            {
                File.Delete(directory.FullName + "\\unrpyc.zip");
                File.Delete(directory.FullName + "\\unrpyc.py");
                File.Delete(directory.FullName + "\\deobfuscate.py");
                Directory.Delete(directory.FullName + "\\decompiler", true);
                executed = false;
            };
            executed = true;
            process.Start();
            process.BeginOutputReadLine();
            while (process.HasExited == false)
                Thread.Sleep(100);

            

            //Process.Start(directory.FullName + "\\", "");
        }

        private void ConsoleCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-console.rpy"))
            {
                consoleWrite.Write(Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.consoleCode)));
                progress.Report("Developer/Console file is created! \n");
            }
        }
        private void QuickCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-quick.rpy"))
            {
                consoleWrite.Write(Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.quickCode)));
                progress.Report("Unren-quick file is created! \n");
            }
        }
        private void SkipCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-skip.rpy"))
            {
                consoleWrite.Write(Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.skipCode)));
                progress.Report("Skip file is created! \n");
            }
        }
        private void RollbackCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-rollback.rpy"))
            {
                consoleWrite.Write(Encoding.UTF8.GetString(Convert.FromBase64String(Base64Codes.rollbackCode)));
                progress.Report("Rollback file is created! \n");
            }
        }
    }
}
