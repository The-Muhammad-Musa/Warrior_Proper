using System;
using static System.Console;

namespace Warrior_Proper
{
    class Program
    {
        static void Main(string[] args)
        {
            fighter testFighter = new fighter("test", 100, 25);
            WriteLine(testFighter.Health);
            testFighter.Health = 50;
            WriteLine(testFighter.Health);
        }
    }
}
