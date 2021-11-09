using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT
{// чувырлик )) хехе
 // сессия 1

    class Program
    {
        static void Main(string[] args)
        {
            // Specifying the length of the array
            Console.Write("Enter the length of the array: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] simpleArray = new int[lenght];
            // Filling the array with elements
            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.Write($"Enter the {i} element of the array: ");
                simpleArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Displaying the minimum element of an array
            Console.WriteLine("Minimum element of an array: " + Min(simpleArray));
            Console.ReadKey();
        }
        // Method for finding the minimum element of an array. 
        public static int Min(int[] array)
        {
            int minimum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
    }
}
