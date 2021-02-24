using RPG_Characters.Models.Heros;
using RPG_Characters.Services.initialize;
using System;

namespace RPG_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
        
            HeroInit heroInit = new HeroInit();
         
   

            Warrior warrior = new Warrior();
            Console.WriteLine(warrior);
            Console.WriteLine("After init Warrior");
            heroInit.initialize(warrior);
            Console.WriteLine(warrior);



        }
    }
}
