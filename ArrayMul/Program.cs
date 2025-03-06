using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Console.WriteLine("Please provide exactly 6 arguments.");
                return;
            }
            
            float a11 = float.Parse(args[0]);
            float a12 = float.Parse(args[1]);
            float a21 = float.Parse(args[2]);
            float a22 = float.Parse(args[3]);
            float b1 = float.Parse(args[4]);
            float b2 = float.Parse(args[5]);
        }
    }
}
