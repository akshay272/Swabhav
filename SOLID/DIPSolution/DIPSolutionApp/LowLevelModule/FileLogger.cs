using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.CommonModule;
namespace DIPSolutionApp.HighLevelModule
{
    class FileLogger : ILogger
    {
        public string Log()
        {
            string message = "Logging to File";
            return message;
        }
    }
}
