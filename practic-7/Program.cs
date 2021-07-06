using System;

namespace practic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            MakeNegative(number);

        }
        public static int MakeNegative(int number)
        {
            
                if (number < 0)
                {
                    return number;
                }
                else if (number == 0)
                {
                    return 0;
                }
                else
                {
                    int u = number * (-1);
                    return u;
                }
        }
    }
}
