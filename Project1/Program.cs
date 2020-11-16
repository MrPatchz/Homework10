/// HW No. 10 Exercise No.1
/// File Name:     Homework10.cs
/// @author:       Jacques Zwielich
/// Date:          Nov. 15, 2020
///
/// Problem Statement: Fix the alien program
///    
/// Overall Plan:
/// 1.  Split the code into multiple files.
/// 2.  Replace the type parameter with inheritance
/// 3.  Delete all constant variables
/// 4.  Rewrite alien to be protected
/// 5.  Use a method to get damage 
/// 6.  rewrite the calculate damage method to use the get damage method of all the children
/// 7.  Write the main function to create and calculate a bunch of alien packs
/// 8.  print out all the childrens damage and the alien packs total damage!
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

    class Program
    {
        static void Main(string[] args)
        {
            AlienPack pack = new AlienPack(4);
            Ogre lug = new Ogre(200, "lug");
            Ogre grug = new Ogre(250, "grug");
            Marshmellow soft = new Marshmellow(100, "softy");
            Snake snek = new Snake(600, "snek");
            pack.AddAlien(lug , 0);
            pack.AddAlien(grug, 1);
            pack.AddAlien(soft, 2);
            pack.AddAlien(snek, 3);
            foreach (Alien a in pack.GetAliens())
            {
                Console.WriteLine(a.getName() + "'s Damage is " + a.GetDamage());
            }
            Console.WriteLine(pack.CalculateDamage());


        }
    }
}
