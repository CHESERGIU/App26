using System;

namespace App26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out int num);
            for (i = 1; i <= num; i++)
                    sum += i*i;                              
            Console.WriteLine(sum);
        }
    }
}
