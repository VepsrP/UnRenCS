using System;
using System.IO;

namespace UnRenCS
{
    internal interface IExecuteCommands
    {
        string Execute(DirectoryInfo directory, Commands commands, IProgress<string> progress);
    }
}
