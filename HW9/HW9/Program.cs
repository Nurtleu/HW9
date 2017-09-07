using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW9
{
    /*
    1.	Создать коллекцию List <int> . Вывести на экран позицию и значение элемента, 
    являющегося вторым максимальным значением в коллекции. Вывести на экран сумму 
    элементов на четных позичиях.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sumOfElemts = new List<int>();

            int size;
            for (;;)
            {
                Write("Введите позицию:");
                if (Int32.TryParse(ReadLine(), out size))
                    break;
            }
            Random random = new Random();
            for(int i=0; i<size; i++)
            {
                sumOfElemts.Add(random.Next() % 100);
                Write("{0}){1}\t", i, sumOfElemts[i]);
            }
            int pos = sumOfElemts[0];
            int max = sumOfElemts[0];
            int twoMax = sumOfElemts[0];
            int posTwoMax = sumOfElemts[0];
            for(int i=0; i< sumOfElemts.Count; i++)
            {
                if (sumOfElemts[i] > max)
                {
                    twoMax = max;
                    max = sumOfElemts[i];
                    posTwoMax = pos;
                    pos = i;
                }
                else if (sumOfElemts[i] > max && sumOfElemts[i] > twoMax)
                {
                    twoMax = sumOfElemts[i];
                    posTwoMax = i;
                }
            }

            WriteLine("\nВторое максимальное значение по позиции {0}", twoMax, posTwoMax);

            int sum = 0;
            for (int i = 0; i < sumOfElemts.Count; i++)
            {
                if (i % 2 == 0)
                {
                    sum += sumOfElemts[i];
                }
            }

            WriteLine("Сумма элементов на четных позициях: " + sum);

            ReadLine();
        }
    }
}
