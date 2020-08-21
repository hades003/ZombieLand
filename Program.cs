using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace ZombieLand
{
    class Program
    {
        static void Main(string[] args)
        {
            ZombieBody chuck = new ZombieBody("chuck",17);
            chuck.printStatus();
            Console.ReadKey();
        }
    }
}
