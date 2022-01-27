using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.MVVM.Models
{
    internal class Log
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public LogType Type { get; set; }
        public DateTime Created { get; set; }
    }
}
