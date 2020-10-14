using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace HandsOn
{
    public class Program
    {
        static float ConvertedTemp;
 

        static int max;
        public static void Main(string[] args)
        {
            var array1 = new int[] { 16, 2, 9, 4 };
            var array2 = new int[] { -5, -2, 1, 0 };

            max = FindMax(array1);
            Console.WriteLine("max number is:" + max);
            max = FindMax(array2);
            Console.WriteLine("max number is:" + max);
            var arrayStr = new string[] { "omnia", "rodyna", "bothyna" };
            Console.WriteLine("before reverse it:");
            foreach (var item in arrayStr)
            {
                Console.WriteLine(item);
            }
            var reverse = ReverseArray(arrayStr);
            Console.WriteLine("after reverse it:");
            foreach (var item in arrayStr)
            {
                Console.WriteLine(item);
            }




        }


        //Find the Max of an Array:
        static int FindMax(int[] array)
        {
            max = array.Max();
            return max;
        }
        // Reverse an array:

        public static string[] ReverseArray(string[] array)

        {
            Array.Reverse(array);
            return array;
        }
        //  Convert temperature
       public static float CovertTemp(string convertTo, float temperature)
        { 
            
            return ConvertedTemp;
        }
    }
}
