using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = args[0];
            Perks playerPerks = Perks.None;
            
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w': 
                        playerPerks ^= Perks.WarpShift; 
                        break; 
                    case 'a': 
                        playerPerks ^= Perks.Stealth; 
                        break;
                    case 's': 
                        playerPerks ^= Perks.AutoHeal; 
                        break;
                    case 'd': 
                        playerPerks ^= Perks.DoubleJump; 
                        break;
                    default: 
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }
        }
    }
    
    [Flags]
    enum Perks
    {
        None = 0,
        WarpShift = 1 << 0,  // 1
        Stealth = 1 << 1,    // 2
        AutoHeal = 1 << 2,   // 4
        DoubleJump = 1 << 3  // 8
    }
}
