using System;

namespace zerosAndOnesInFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int numberOfCase = int.Parse(input);

            while (numberOfCase-- > 0)
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"{ howManyZeros(num)} {howManyOnes(num)}");
            }
        }

        static int howManyZeros(int n)
        {
            int result = 0;
            if (n == 0)
            {
                result = 1;
            }

            else if (n == 1)
            {
                result = 0;
            }
                        
            if (n > 1 )
            {
                int[] solution = new int[n+1];
                solution[0] = 1;
                solution[1] = 0;

                for (int i = 2; i < solution.Length; i++)
                {
                    solution[i] = solution[i - 1] + solution[i - 2];
                }
                result = solution[n];
            }
            
            return result;
        }

        static int howManyOnes(int n)
        {
            int result = 0;
            if (n == 0)
            {
                result = 0;
            }

            else if (n == 1)
            {
                result = 1;
            }
            if (n > 1)
            {
                int[] solution = new int[n+1];
                solution[0] = 0;
                solution[1] = 1;

                for (int i = 2; i < solution.Length; i++)
                {
                    solution[i] = solution[i - 1] + solution[i - 2];
                }
                result = solution[n];
            }

            return result;
        }
    }
}