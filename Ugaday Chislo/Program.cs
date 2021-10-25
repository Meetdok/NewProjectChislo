using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugaday_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(10);
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);

            char again = 'y';

            while (again == 'y')
            {
                int a = rand.Next(10);

                Console.WriteLine("Компьютер загадал число от 0 до 10");

                int b = Convert.ToInt32(Console.ReadLine());

                if (i == b) Console.WriteLine("Угадал!!!");
                if (i > b) Console.WriteLine("Мало!");
                if (i < b) Console.WriteLine("Много!");

                Console.WriteLine("Попробовать еще? (y = Да, n = Нет)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
