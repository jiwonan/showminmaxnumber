using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = array[0];
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (min > array[i])
                    min = array[i];
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine("가장 큰 수: " + max);
            Console.WriteLine("가장 작은 수: " + min);
        }
    }
}
