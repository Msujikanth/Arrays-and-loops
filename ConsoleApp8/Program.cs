using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string a, b, c, d, e;
            Console.WriteLine("Enter number 1");
                a = Console.ReadLine();
            Console.WriteLine("Enter Number 2");
                b = Console.ReadLine();
            Console.WriteLine("Enter Number 3");
                c = Console.ReadLine();
            Console.WriteLine("Enter Number 4");
                d = Console.ReadLine();
            Console.WriteLine("Enter Number 5");
                e = Console.ReadLine();

                int z = int.Parse(a);
                int y = int.Parse(b);
                int x = int.Parse(c);
                int w = int.Parse(d);
                int v = int.Parse(e);
            
            int[] intArray;

            intArray = new int[5];
            intArray[0] = z;
            intArray[1] = y;
            intArray[2] = x;
            intArray[3] = w;
            intArray[4] = v;

            // using for loop
            Console.Write("For loop        :");
            for (int i = 0; i < 5; i++)
                Console.Write(" " + intArray[i]);

            Console.WriteLine("");//for space after every print 
            Console.Write("For-each loop   :");

            // using for-each loop 
            foreach (int i in intArray)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop      :");

            // using while loop 
            int j = 0;
            while (j < 5)
            {
                Console.Write(" " + intArray[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop   :");

            // using do-while loop 
            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);
            Console.ReadKey();
        }
    }
}
