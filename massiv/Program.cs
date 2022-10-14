using System;

namespace massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[100];
            Random rnd = new Random(DateTime.Now.Millisecond);
            int i = 0;
            int Sum = 0;
            for (i = 0; i < A.Length; i++)
            {
                int x = rnd.Next(-1000, 1001);
                A[i] = x;
                if (A[i] % 2 == 0)

                {
                    Console.Write(A[i] + " " + "Четное");
                }
                Console.WriteLine();
                if (A[i] % 3 == 0)
                {
                    Console.Write(A[i] + " " + "Делится на 3");
                }
                Console.WriteLine();
                if (A[i] < 0)
                {
                    Sum += A[i];
                }
            }
            Console.WriteLine(Sum);
        }
    }
}
