using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumKitTestDrive.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            DrumKit drumKit1 = new DrumKit();
            DrumKit drumKit2 = new DrumKit();
            DrumKit drumKit3 = new DrumKit();

            drumKit1.snare = true;
            drumKit1.topHat = true;
            drumKit1.PlaySnare(5);
            drumKit1.PlayTopHat(2);

            drumKit2.topHat = false;
            drumKit2.PlaySnare(1);
           
            drumKit3.PlaySnare(2);
            drumKit3.PlayTopHat(4); 
            Console.ReadKey();    
        }
    }
}
