using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void Log_MessageAppendsTofile_Success()
    {
        var filePath = "test.log";
        var logger = new FileLogger(filePath) { ClassName = "TestClass" };
        var logMessage = "Test Message";

        logger.Log(LogLevel.Information, logMessage);

        string[] lines = System.IO.File.ReadAllLines(filePath);
        Assert.AreEqual($"{DateTime.Now} TestClass Information: {logMessage}", lines[^1]);
    }
    
}
