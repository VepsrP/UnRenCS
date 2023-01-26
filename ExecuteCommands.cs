using System.Collections.Generic;
using System.IO;

namespace UnRenCS
{
    internal class ExecuteCommands : IExecuteCommands
    {
        public void Execute(DirectoryInfo directory, List<bool> commands)
        {
            ConsoleCommand(directory);
        }

        private void ConsoleCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-console.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Base64Codes.consoleCode)));
            }
        }
    }
}
