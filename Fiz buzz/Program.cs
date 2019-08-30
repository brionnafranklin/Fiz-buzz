using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiz_buzz
{
    class Program
    {

        static void Main(String[] args)
        {
            int number = 0;

            while (-1 < number && number < 100)
            {

                number++;
                Console.WriteLine(number);

                //check for 5

                if (number == 5 || number == 10 || number == 15 || number == 20 || number == 25 || number == 30 || number == 35 || number == 40 || number == 45 || number == 50 || number == 55 || number == 60 || number == 65 || number == 70 || number == 75 || number == 80 || number == 85 || number == 90 || number == 95 || number == 100)
                {
                    Buzz();
                }

                //check for 3
                if (number % 3 == 0)
                {
                    Fizz();
                }
            }

            void Buzz()
            {
                Console.WriteLine("Buzz");
            }
            void Fizz()
            {
                Console.WriteLine("Fizz");
            }
            Console.ReadLine();
        }
    }
}
