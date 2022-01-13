using System;

namespace Recursivitate___1
{
    class Program
    {
        public static void ParcurgereVector(int[] array, int n)
        {
            if (n == 1)
                Console.WriteLine(array[n - 1]);
            else
            {

                ParcurgereVector(array, n - 1);
                Console.WriteLine(array[n - 1]);
            }
        }

                static void Main(string[] args)
                {
                         Console.Write("Cate numeri vrei sa citesti de la tastatura?");
                         int nrElements = int.Parse(Console.ReadLine());
                         int[] array = new int[nrElements];
                         for (int i = 0; i < nrElements; i++)
                         {
                         Console.Write("The " + (i + 1) + ". element = ");
                         array[i] = int.Parse(Console.ReadLine());
                         }

                         ParcurgereVector(array, array.Length);
                }
            
    
    }
}
