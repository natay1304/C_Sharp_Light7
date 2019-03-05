using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int awaitTime = 10;
            Console.Write("Введите количество человек в очереди - ");
            int clientsCount = Convert.ToInt32(Console.ReadLine());
            int fullTime = clientsCount * awaitTime;
            int hours = fullTime / 60;
            int minutes = fullTime % 60;
            Console.WriteLine("Вы должны отстоять в очереди " + hours + " час(ов) " + minutes + " минут(ы).");
        }
    }
}
