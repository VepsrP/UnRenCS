using System.Collections.Generic;
using System.IO;

namespace UnRenC
{
    internal interface IExecuteCommands
    {
        void Execute(DirectoryInfo directory, List<bool> commands);
    }
}
