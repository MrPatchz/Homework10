using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Snake : Alien
    {
        public Snake(int health, string name) :
            base(health, name) { }
        public override int GetDamage()
        {
            return 10;
        }
    }
}
