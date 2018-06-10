using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести два цілих числа day та month і перевірити чи можуть вони представляти день та місяць.
            //Вивести true чи false
            int day;
            int month;
            DateTime dt;

            Console.WriteLine("Enter day:");            
            if (Int32.TryParse(Console.ReadLine(), out day)) { }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }

            Console.WriteLine("Enter month");
            if (Int32.TryParse(Console.ReadLine(), out month)) { }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }

            if (DateTime.TryParse(string.Format("{0}-{1}-{2}", DateTime.Now.Year, month, day), out dt)) { }
            else
            {
                Console.WriteLine("Month and day could not represent datetime.");                
            }
            Console.ReadKey();

        }              
    }
}
