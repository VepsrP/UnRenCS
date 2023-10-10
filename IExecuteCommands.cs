﻿using System;
using System.IO;

namespace UnRenCS
{
    internal interface IExecuteCommands
    {
        void Execute(DirectoryInfo directory, Commands commands, IProgress<string> progress);
    }
}
