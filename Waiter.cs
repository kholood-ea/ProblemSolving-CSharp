using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class Waiter
    {

        public static int[] waiter(int[] number, int q)
        {
            List<int> result = new List<int>();
            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> B1 = new Stack<int>();

            List<int> PrimeNumbers = new List<int>();
            PrimeNumbers.Add(2);
            for (int i = 3; i <= 1200; i++)
            {
                if (i % 2 != 0)
                {
                    PrimeNumbers.Add(i);
                }
            }
            for (int i = 0; i < q - 1; i++)
            {
                for (int j = number.Length - 1; j >= 0; j--)
                {
                    if (number[j] % PrimeNumbers[i] != 0)
                    {
                        A.Push(number[j]);
                    }
                    else
                    {
                        B.Push(number[j]);
                    }
                }
                while (i != q - 1)
                {
                    B1 = A;
                    A.Clear();
                    if (B1.Peek() % PrimeNumbers[i + 1] == 0)
                    {
                        A.Push(B1.Pop());
                    }



                }
            }
            while (B.Count != 0)
            {
                System.Console.WriteLine($"{B.Peek()} Stack B");
                result.Add(B.Peek());
                B.Pop();
            }
            while (A.Count != 0)
            {
                System.Console.WriteLine($"{A.Peek()} Stack A");

                result.Add(A.Peek());
                A.Pop();
            }

            return result.ToArray();

        }

        public static void ReadVar()
        {

            string[] nq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nq[0]);

            int q = Convert.ToInt32(nq[1]);

            int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), numberTemp => Convert.ToInt32(numberTemp))
            ;
            int[] result = waiter(number, q);
            System.Console.WriteLine(string.Join("\n", result));


        }
    }
}