using log4net;
using log4net.Appender;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace MatrixLogForNet
{
    class Program
    {
        //Using reflection to get Program.cs name for the logger
        // private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
        //   System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("program.cs");

        
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());                
                 double ms = RunLoop(input);                               
                string date = DateTime.Today.ToString("dd/MM/yyy");
                string logInformation = String.Format("{0} - Input: {1} - Time: {2} ms",
                    date, input, ms);
                Console.WriteLine("Time in miliseconds: " + ms);
                log.Info(logInformation);
            }
            catch (Exception)
            {

                Console.WriteLine("You entered an invalid number");
            }
            Console.Write("\nPress any key to exit..");
            Console.ReadKey();
        }


        /// <summary>
        /// Counts how log it takes to finish a for loop
        /// </summary>
        /// <param name="iterations">number of iterations</param>
        /// <returns>time in miliseconds</returns>
        static double RunLoop(int iterations)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < iterations; i++)
            {

            }
            s.Stop();
            var res = s.Elapsed.TotalMilliseconds;
            return res;
        }
    }
}
