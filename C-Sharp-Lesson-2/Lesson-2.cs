using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_2
{
    public class Lesson_2
    {
        static public void Main(String[] args)
        {
            //Using a for loop to print to console all odd numbers from zero to 20

            for (int j = 0; j < 20; j++)
            {
                if (j % 2 == 0) { Console.WriteLine(j); }

            }
            //with while
            int i = 0;
            while (i < 20)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
                i++;
            }
            //do - while
            // calculate summ of numbers from 0 to 10
            int k = 0;
            int sum = 0;
            do
            {
                sum += k;
                k++;
            }
            while (k == 10);

            //foreach
            int[] arrayOfIntegers = { -1, 2, 35, 84, -100 };

            foreach (int number in arrayOfIntegers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
