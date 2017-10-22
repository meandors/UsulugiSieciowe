using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.CalculatorServiceReference;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {


                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Dzielenie");
                Console.WriteLine("3 Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        double a, b;
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        CalcClient client = new CalcClient();
                        double wynik = client.Add(a, b);
                        Console.WriteLine("Wynik: "+ wynik);
                        client.Close();
                        break;
                }

            } while (Console.ReadLine() != "3");
        }
    }
}
