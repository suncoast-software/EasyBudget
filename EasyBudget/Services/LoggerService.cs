using EasyBudget.MVVM.Models;
using EasyBudget.Services.Interfaces;
using System;
using System.IO;
using System.Text;

namespace EasyBudget.Services
{
    internal class LoggerService : ILoggerService
    {
        public void Log(Log log)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\logs\\log.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.ASCII))
            {
                sw.WriteLine($"ID: {log.Id}\r\n");
                sw.WriteLine($"Type: {log.Type}\r\n");
                sw.WriteLine($"Message: {log.Message}\r\n");
                sw.WriteLine($"Created: {log.Created}\r\n");
                sw.WriteLine("_________________________________________\r\n");
            }
        }
    }
}
