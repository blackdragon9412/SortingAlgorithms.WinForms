using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortieralgorithmen_MT
{
    class Zeit
    {

       public static Stopwatch Watch_Start()
       {

            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            return sw;
       }

        public static TimeSpan Watch_Stop(Stopwatch sw) 
        {

            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            return ts;

        }



    }
}
