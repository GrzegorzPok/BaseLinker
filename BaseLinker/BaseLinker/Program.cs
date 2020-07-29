using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BaseLinker
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            string str;
            ApiHelper.InitializeClient();
            var processor = new BaseLinkerProcessor();

            do
            {
                Console.WriteLine("Enter the order's ID to copy. \nIf you want, you can also " +
                   "enter the number of copies and the time interval beetween the copies" +
                   "\nEXAMPLES" +
                   "\n112 -> order with id = 112 will be copied" +
                   "\n112 3 5 -> order with id = 112 will be copied 3 times at intervals of 5 seconds");

                var input = Console.ReadLine();
                var splittedStr = input.Split(' ');

                var parameters = new InputParameters();
                parameters.FillParameters(splittedStr);

                if (!parameters.IsCorrect)
                {
                    str = "y";
                    continue;
                }

                Console.WriteLine("DOWNLOADING THE ORDER...");
                var orderResult = await processor.LoadOrder(parameters.OrderId);

                ShowOrder(orderResult);

                Console.WriteLine("START COPYING THE ABOVE ORDER...");
                await CopyOrder(processor, orderResult, parameters);

                Console.WriteLine("COPYING COMPLETE\n");
                Console.WriteLine("Continue? (y - yes)");
                str = Console.ReadLine();
            } while (str.Equals("y"));
        }

        private static async Task CopyOrder(BaseLinkerProcessor processor, OrderResult orderResult, InputParameters parameter)
        {
            if (parameter.NumberOfCopies != null || parameter.NumberOfCopies != 0)
            {
                for (int i = 0; i < parameter.NumberOfCopies; i++)
                {
                    if (parameter.Seconds.HasValue)
                    {
                        Thread.Sleep(parameter.Seconds.Value * 1000);
                    }
                    var copiedOrder = await processor.AddOrder(orderResult);
                    Console.WriteLine("Copied order = " + copiedOrder + "\n");
                }
            }
        }

        private static void ShowOrder(OrderResult orderResult)
        {
            Console.WriteLine(orderResult.ToString());
        }
    }
}
