using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void FileLogger_Log_MessageAppendedToFile()
    {
        var filePath = 'test.log';
        var logger = new FileLoggerTests(filePath) { ClassName = 'TestClass' };
        var logMessage = "Test Message";

        logger.Log(LogLevel.Information, logMessage);

        string[] lines = File.ReadAllLines(filePath);
        Assert.AreEqual($"{DateTime.Now} TestClass Information: {logMessage}", lines[^1]);
    }
    
}
