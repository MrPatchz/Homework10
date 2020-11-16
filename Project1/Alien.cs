using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Alien
    {
        protected int health; //0 = dead, 100 = full
        protected string name;

        public Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public virtual int GetDamage()
        {
            return 0;
        }
    }
}
