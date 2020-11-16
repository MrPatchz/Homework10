using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Ogre : Alien
    {
        public Ogre(int health, string name) :
            base(health, name) { }
        public override int GetDamage()
        {
            return 8;
        }
    }


}
