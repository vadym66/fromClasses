//Виталий Кучеров

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task20();
        }

        static void Task1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Task2()
        {
            for (int i = 100; i <= 200; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Task2_1()
        {
            for (int i = 200; i >= 100; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void Task3()
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Task4()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void Task5()
        {
            int mul = 1;
            for (int i = 1; i <= 10; i++)
            {
                mul *= i;
            }
            Console.WriteLine(mul);
        }

        static void Task6()
        {
            Console.WriteLine("Input number: ");
            int num = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            int i = 0;
            while (num > 0)
            {
                arr.Add(num % 10);
                num /= 10;
                i++;
            }
            arr.Reverse();
            foreach (var item in arr)
                Console.WriteLine(item);
        }

        static void Task6_1()
        {
            Console.WriteLine("Input number: ");
            double intPart;
            double doublePart;

            double number = Convert.ToDouble(Console.ReadLine());

            intPart = (int)number;
            Console.WriteLine(intPart);

            doublePart = number - intPart;
            Console.WriteLine(doublePart * 10);


        }

        static void Task7()
        {
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
        }

        static void Task8()
        {
            Console.WriteLine("Input string:");
            string str = Console.ReadLine();
            List<char> strList = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                strList.Add(str[i]);
            }
            strList.Reverse();
            foreach (var item in strList)
                Console.Write(item);
            Console.WriteLine("\n");
        }

        static void Task9()
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var i in arr)
                Console.WriteLine(i);
        }

        static void Task10()
        {
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 1; i < size+1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i-1] = int.Parse(Console.ReadLine());
            }
        }

        static void Task11()
        {
            int sum = 0;
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 1; i < size + 1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i - 1] = int.Parse(Console.ReadLine());
                sum += arr[i - 1];
            }
            Console.WriteLine(sum);
        }

        static void Task12()
        {
            int mul = 1;
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 1; i < size + 1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i - 1] = int.Parse(Console.ReadLine());
                mul *= arr[i - 1];
            }
            Console.WriteLine(mul);
        }

        static void Task13()
        {
            
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int min = arr[0];
            for (int i = 1; i < size + 1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i - 1] = int.Parse(Console.ReadLine());        
            }

            for (int i = 1, count = 0 ; i < size; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    min = arr[i];
                    count++;
                }
                if(count == 0)
                {
                    min = arr[0];
                }

            }
            Console.WriteLine(min);
        }

        static void Task14()
        {
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int max = arr[0];
            for (int i = 1; i < size + 1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i - 1] = int.Parse(Console.ReadLine());
            }

            for (int i = 1, count = 0; i < size; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    max = arr[i];
                    count++;
                }
                
                if (count == 0)
                {
                    max = arr[0];
                }
            }
            Console.WriteLine(max);
        }

        static void Task15()
        {
             
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int min = arr[0];
            int sum = 0;
            int medAriph;
            for (int i = 1; i < size + 1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i - 1] = int.Parse(Console.ReadLine());
                sum += arr[i-1];
            }
            medAriph = sum / size;
            Console.WriteLine(medAriph);
        }

        static void Task16()
        {
            Console.WriteLine("Input size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < size + 1; i++)
            {
                Console.WriteLine("Input " + i + " element:");
                arr[i - 1] = int.Parse(Console.ReadLine());
            }

            for (int i = 1, count = 0; i < size; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    min = i-1;
                    count++;
                }
                if (count == 0)
                {
                    min = arr[0];
                }

            }
            Console.WriteLine("Min = " + min);

            for (int i = 1, count = 0; i < size; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    max = i-1;
                    count++;
                }

                if (count == 0)
                {
                    max = arr[0];
                }
            }
            Console.WriteLine("Max = " + max);

            Console.WriteLine(arr[min]);
            Console.WriteLine(arr[max]);
        }

        static void Task17()
        {
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next() % 10;
                arr2[i] = rand.Next() % 10;
            }
            Console.WriteLine("Your array 1 : ");
            foreach (var i in arr1)
                Console.WriteLine(i);
            Console.WriteLine("Your array 2 : ");
            foreach(var i in arr2)
                Console.WriteLine(i);

            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    Console.WriteLine("Massives are not equal");
                    break;
                }
            }
        }

        static void Task18()
        {
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 10;
            }

            Console.WriteLine("Your array:");
            foreach(var i in arr)
                Console.WriteLine(i);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
            Console.WriteLine("Your new array:");
            foreach (var i in arr)
                Console.WriteLine(i);
        }

        static void Task19()
        {
            List<string> strings = new List<string>();

            Console.WriteLine("Enter strings until 'end' string ");

            string str = "1";

            while(str != "end")
            {
                str = Console.ReadLine();
                strings.Add(str);
            }
            int count = strings.Count;
            strings.Remove(strings[count - 1]);
            Console.WriteLine("Enter substring to find it in another strings:");
            string subString = Console.ReadLine();
            int first = 0;

            Console.WriteLine("Strings thoose contains " + subString);
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].Contains(subString))
                {
                    Console.WriteLine(strings[i]);
                    if(first == 0)
                        first = i+1;
                }             
            }
            Console.WriteLine("First enter is " + first);
        }
        
        static void Task20()
        {
            List<string> strings = new List<string>();

            Console.WriteLine("Enter strings until 'end' string ");

            string str = "1";

            while (str != "end")
            {
                str = Console.ReadLine();
                strings.Add(str);
            }
            int count = strings.Count;
            strings.Remove(strings[count - 1]);
            Console.WriteLine("Enter substring to find it in another strings:");
            string subString = Console.ReadLine();

            for (int i = 0; i < strings.Count; i++)
            {
                if(strings[i].Contains(subString))
                {
                    strings[i].Trim(subString);
                }
            }
        }
    } 
}
