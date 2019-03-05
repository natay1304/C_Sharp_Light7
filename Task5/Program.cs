using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 52;
            int column = 3;
            int row = count / column;
            int d = count % column;
            Console.WriteLine(row + " - количество полностью заполненных рядов; " + d + " - количество оставшихся картинок");
        }
    }
}
