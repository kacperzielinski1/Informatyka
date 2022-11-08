using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace konsolowykalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wynik = 0;
            Console.WriteLine("---------------------");
            Console.WriteLine("Kalkulator");
            Console.WriteLine("---------------------");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Podaj liczbę pierwszą: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę drugą: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Wybierz opcje: ");
            Console.WriteLine("\t + dodawanie ");
            Console.WriteLine("\t - odejmowanie ");
            Console.WriteLine("\t * mnożenie");
            Console.WriteLine("\t / dzielenie");
            Console.Clear();
            switch (Console.ReadLine())
            {
                case "+":
                    wynik = num1 + num2;
                    Console.WriteLine($"Wynik: {wynik}");
                    break;
                case "-":
                    wynik = num1 - num2;
                    Console.WriteLine($"Wynik: {wynik}");
                    break;
                case "*":
                    wynik = num1 * num2;
                    Console.WriteLine($"Wynik: {wynik}");
                    break;
                case "/":
                    wynik = num1 / num2;
                    Console.WriteLine($"Wynik: {wynik}");
                    break;
                default:
                    Console.WriteLine("Podano złą opcję!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
