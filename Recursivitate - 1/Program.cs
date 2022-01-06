using System;

namespace Recursivitate___1
{
    class Program
    {
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
            Console.WriteLine(array);
        }
    }
}
