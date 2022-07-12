using System;

namespace Sweeft_Digital_2
{
    internal class Program
    {
        static int minSplit(int amount)
        {
            int[] monets = { 1, 5, 10, 20, 50 };
            int counter = 0, littleCounter = monets.Length;
            while (true)
            {
                int lastMember = monets[littleCounter - 1];
                if (amount == lastMember)
                {
                     counter++;
                       break;
                }
                else
                {
                    if (amount > lastMember)
                    {
                    amount -= lastMember;
                    counter++;
                    }
                    else                    
                    littleCounter--;
                    
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int result = minSplit(17);
            Console.WriteLine(result);
        }
    }
}
