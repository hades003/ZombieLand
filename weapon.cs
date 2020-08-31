using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieLand
{
    class weapon
    {
        private int range;
        private int spread;
        private char damageType;

        public weapon(int rng, int spr, char dmg)
        {
            range = rng;
            spread = spr;
            damageType = dmg;
        }

        public int getRange() 
        {
            return range;
        }

        public int getSpread()
        {
            return spread;
        }

        public char getDamageType() 
        {
            return damageType;
        }
    }
}
