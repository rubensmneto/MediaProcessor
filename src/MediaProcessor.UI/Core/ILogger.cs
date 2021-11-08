using System;

namespace MediaProcessor.UI.Core
{
    internal interface ILogger
    {
        void RegisterFileProcessing(string sourcePath, string targetPath, DateTime? fileDate, DateTime processingDate, string status);
    }
}