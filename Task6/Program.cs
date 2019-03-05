using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько у Вас ед. золота? (введите число) - ");
            int gold = Convert.ToInt32(Console.ReadLine());
            int price = 5;

            if (gold > price)
            {
                Console.Write("Сколько кристаллов вы хотите купить (цена кристалла - " + price + ")? - ");
                int goodCount = Convert.ToInt32(Console.ReadLine());
                
                while (true)
                {
                    if (gold >= price * goodCount)
                    {
                        int totalCheck = price * goodCount;
                        gold = gold - totalCheck;
                        Console.WriteLine("Вы купили " + goodCount + " кристалла(ов)." + " У вас осталось " + gold + " ед. золота.");
                        break;
                    }

                    else
                    {
                        Console.Write("Вам не хватает золота для покупки такого количества кристалов. Введите другое количество кристаллов - ");
                        goodCount = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            else
            {
                Console.WriteLine("Цена кристалла 5 ед. золота. У вас не достаточно золота для покупки.");
            }
        }
    }
}
