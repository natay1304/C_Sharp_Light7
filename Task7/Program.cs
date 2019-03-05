using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int awaitTime = 10;
            Console.Write("Введите количество человек в очереди - ");
            int clientsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы должны отстоять в очереди " + awaitTime * clientsCount + " минут.");
        }
    }
}
