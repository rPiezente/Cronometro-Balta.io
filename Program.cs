using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("(S) Segundos => 1s = 1 segundo");
            Console.WriteLine("(M) Minutos => 1m = 1 minuto");
            Console.WriteLine("(H) Horas => 1h = 1 hora");
            Console.WriteLine("(0) Para sair");
            Console.WriteLine("Digite uma opção: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0,data.Length-1));
            int multplier = 1;

            if (type == 'm')
                multplier = 60;
                if (type == 'h')
                multplier = 3600;
            if (time == 0)
                System.Environment.Exit(0);
            
            PreStart(time * multplier);
        }

        static void PreStart(int time)
        {   
            Console.Clear();
            Console.WriteLine("Preparando...");
            Thread.Sleep(700);
            Console.WriteLine("3...");
            Thread.Sleep(700);
            Console.WriteLine("2...");
            Thread.Sleep(700);
            Console.WriteLine("1...");
            Thread.Sleep(700);
            Console.WriteLine("Vai!!");
            Thread.Sleep(1000);
            Start(time);

        }
        static void Start(int time)
        {
            
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}