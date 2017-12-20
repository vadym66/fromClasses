using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static int cmp;
        static int prs;
        static int sum;
        static void Main(string[] args)
        {
           
            int[] arr = new int[10] { 1, 4, 9, 3, 5, 1, 8, 6, 2, 6 };
            int[] arr1 = new int[10] { 1, 4, 9, 3, 5, 1, 8, 6, 2, 6 };
            sortBad(arr);
            

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            sum = cmp + prs;
            Console.WriteLine("Sum of operations = " + sum);

            sum = cmp = prs;
            sortGood(arr1);
            foreach (var i in arr1)
            {
                Console.WriteLine(i);
            }

            sum = cmp + prs;
            Console.WriteLine("Sum of operations = " + sum);

        }
        static void sortGood(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                cmp++;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    cmp++;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        j++;
                        prs++;
                    }
                }
            }
        }

        static void sortBad(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                cmp++;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    cmp++;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        prs++;
                    }
                }
            }
        }

    }
}
