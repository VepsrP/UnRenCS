using System.IO;

namespace UnRenCS
{
    internal class ExecuteCommands : IExecuteCommands
    {
        public void Execute(DirectoryInfo directory, Commands commands)
        {
            if (commands.Console) ConsoleCommand(directory);
            if (commands.Quick) QuickCommand(directory);
            if (commands.Skip) SkipCommand(directory);
            if (commands.Rollback) RollbackCommand(directory);
        }

        private void ConsoleCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-console.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Base64Codes.consoleCode)));
            }
        }
        private void QuickCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-quick.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Base64Codes.quickCode)));
            }
        }
        private void SkipCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-skip.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Base64Codes.skipCode)));
            }
        }
        private void RollbackCommand(DirectoryInfo directory)
        {
            using (StreamWriter consoleWrite = new StreamWriter(directory.FullName + "\\game\\unren-rollback.rpy"))
            {
                consoleWrite.Write(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Base64Codes.rollbackCode)));
            }
        }
    }
}
