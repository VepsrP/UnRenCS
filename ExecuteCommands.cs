using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace UnRenC
{
    internal class ExecuteCommands : IExecuteCommands
    {
        public void Execute(DirectoryInfo directory, List<bool> commands)
        {
            ConsoleCommand(directory);
        }

        private void ConsoleCommand(DirectoryInfo directory)
        {
            
            FileInfo console = new FileInfo(directory.FullName + "\\unren-console.rpy");
            Console.WriteLine(console.FullName);
            //console.Create();
        }
    }
}
