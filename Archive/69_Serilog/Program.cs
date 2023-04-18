using Serilog;
using System;

namespace _69_Serilog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var log = new LoggerConfiguration()
                                    .MinimumLevel.Debug()
                                    .WriteTo.Console()
                                    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                                    .CreateLogger();

            log.Information("Application started!");

            int a = 10, b = 0;
            for (int i = 10; i > -1; i--)
            {
                try
                {
                    log.Debug("Deviding " + a + " by " + i);
                    Console.Write("Deviding " + a + " by " + i + " : ");
                    Console.WriteLine(a / i);
                }
                catch (Exception ex)
                {
                    log.Error(ex, "Something went wrong");
                }
            }
            
            Log.CloseAndFlush();
            

        }
    }
}
