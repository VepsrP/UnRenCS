using System.Collections.Generic;
using System.IO;

namespace UnRenCS
{
    internal interface IExecuteCommands
    {
        void Execute(DirectoryInfo directory, List<bool> commands);
    }
}
