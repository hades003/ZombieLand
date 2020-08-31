using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace ZombieLand
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player();
            me.createCharacter(); 

            Console.ReadKey();
        }
    }
}
