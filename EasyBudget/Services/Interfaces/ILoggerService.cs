using EasyBudget.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.Services.Interfaces
{
    internal interface ILoggerService
    {
        public void Log(Log log);
    }
}
