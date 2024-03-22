using System;

namespace RanDice
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            int sum = SumDice(n, s);
            Console.WriteLine(sum);
        }

        static int SumDice(int rolls, int seed)
        {
            int result = 0;
            Random r = new Random(seed);
            for (int i = 0; i < rolls; i++)
            {
                result += r.Next(1, 7);
            }
            return result;
        }
    }
}
