using EasyBudget.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.Services.Interfaces
{
    internal interface IDataService
    {
        public ConfigJson GetConfigurationJson();
    }
}
