using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class StopWatch
    {
        public static void StopWatch1()
        {
            Console.WriteLine("The stopwatch, press S to begin and Q to stop");
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            var done = false;

            while (!done)
            {
                var UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "s":
                        stopWatch.Start();
                        break;
                    case "q":
                        stopWatch.Stop();
                        done = true;
                        break;
                    default:
                        Console.WriteLine("You did something wrong");
                        break;
                }
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 2);
                Console.WriteLine("RunTime " + elapsedTime);
                Console.ReadLine();
            }

        }

   }
}