﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private readonly string filePath;
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public override void Log(LogLevel logLevel, string message)
        {
            string logEntry = $"{DateTime.Now} {ClassName} {logLevel}: {message}";

            File.AppendAllText(filePath, logEntry + Environment.NewLine);
        }
    }
}
