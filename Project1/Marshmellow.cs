using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Marshmellow : Alien
    {
        public Marshmellow(int health, string name) :
            base(health, name) { }
        public override int GetDamage()
        {
            return 1;
        }
    }
}
