using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (string arg in args)
            {
                // Check if the argument length is greater than 3
                if (arg.Length > 3)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }

}
