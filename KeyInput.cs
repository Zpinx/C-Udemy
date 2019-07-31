using System;
using System.Diagnostics;


namespace Csharp310719
{
    public class StopWatch
    {
        public static void _stopWatch()
        {
            var stopWatch = new Stopwatch();

            start:
            stopWatch.Start();
            Console.WriteLine("\ntime started..\npress Enter to Stop");
            Console.ReadKey();
            var ts = stopWatch.Elapsed;
            stopWatch.Stop();
            Console.WriteLine("\ntime stopped...Press Enter to start again");
            var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadKey();
            goto start;
            
        }
    }
}




                
                    





                    
  