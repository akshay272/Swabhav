using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPVoilationApp.HighLevelModule;
using DIPVoilationApp.LowLevelModule;
namespace DIPVoilationApp.HighLevelModule
{
    class TaxCalculatorcs
    {
        private LogType _policy;
        public TaxCalculatorcs(LogType logPolicy)
        {
            this._policy = logPolicy;

            if (_policy == LogType.DB)
            {
                Console.WriteLine(new DBLogger().WriteLine());
            }
            else
            {
                Console.WriteLine(new FileLogger().WriteLine());
            }
        }

        public int Calculate(int value1, int value2)
        {
            int result=0;
            try
            {
                result = value1 / value2;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return result;
        }
    }
}
