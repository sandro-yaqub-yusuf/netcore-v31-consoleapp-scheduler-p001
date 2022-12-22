using System;

namespace KITAB.Scheduler.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando a SCHEDULER...");
            Console.WriteLine("");
            Console.WriteLine("Serão criadas 4 tarefas:");
            Console.WriteLine("1. Executar a partir das 13:00 hs com chamadas a cada 10 segundos");
            Console.WriteLine("2. Executar a partir das 15:15 hs com chamadas a cada 1 minuto");
            Console.WriteLine("3. Executar a partir das 17:30 hs com chamadas a cada 1 hora");
            Console.WriteLine("4. Executar a partir das 19:45 hs com chamadas a cada 1 dia");
            Console.WriteLine("");

            // For Interval in Seconds 
            // IntervalInSeconds(start_hour, start_minute, seconds)
            MyScheduler.IntervalInSeconds(13, 00, 10, () => 
            {
                Console.WriteLine("Tarefa disparada as 13:00 hs com chamadas a cada 10 segundos");
            });

            // For Interval in Minutes 
            // IntervalInMinutes(start_hour, start_minute, minutes)
            MyScheduler.IntervalInMinutes(15, 15, 1, () => 
            {
                Console.WriteLine("Tarefa disparada as 15:15 hs com chamadas a cada 1 minuto");
            });

            // For Interval in Hours 
            // IntervalInHours(start_hour, start_minute, hours)
            MyScheduler.IntervalInHours(17, 30, 1, () => 
            {
                Console.WriteLine("Tarefa disparada as 17:30 hs com chamadas a cada 1 hora");
            });

            // For Interval in Days
            // IntervalInDays(start_hour, start_minute, days)
            MyScheduler.IntervalInDays(19, 45, 1, () => 
            {
                Console.WriteLine("Tarefa disparada as 19:45 hs com chamadas a cada 1 dia");
            });

            Console.ReadLine();
        }
    }
}
