using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumKitTestDrive.Model
{
    class DrumKit
    {
        public bool topHat = true;
        public bool snare = true;
        public int repeatTime = 1;
        
        public void PlayTopHat(int repeatTime)
        {
            if (topHat == true)
            {
                for (int repeat = 1; repeat <= repeatTime; repeat++)
                {
                    Console.WriteLine("ding ding da-ding");
                }
                Console.WriteLine("");
                repeatTime = 1;
            }
        }

        public void PlaySnare(int repeatTime)
        {
            if (snare == true)
            {
                for (int repeat = 1; repeat <= repeatTime; repeat++)
                {
                    Console.WriteLine("bang bang ba-bang");
                }
                Console.WriteLine("");
                repeatTime = 1;
            }  
        }
    }
}
