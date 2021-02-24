using RPG_Characters.Models.Armors;
using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Services.IncreaseLevel
{
    // This class will handle all next level operations 
   public class NextLevel
    {
       
        public NextLevel()
        {
             
        }
       

        //This method will level up the level of the hero 
        public static void LevelUp(Hero hero,int Experience)
        {
            hero.CurrentExperience += Experience;
           
            if (hero.CurrentExperience >= hero.ExperinceToNextLevel)
            {
                hero.Level++;
                GainsOnLevelUp(hero);
                Console.WriteLine($"ExperinceToNextLevel :{ hero.ExperinceToNextLevel }");

            }

            UpdateTheNewLevelXP(hero);



        }


        public static void UpdateTheNewLevelXP(Hero hero)
        {
            int xpToNextLevel = (int)((0.1) * hero.CurrentExperience);
            hero.ExperinceToNextLevel = xpToNextLevel + hero.CurrentExperience;
           ;

        }

        //This method for gaing which the charcter will get on level up
        //Depending on the type 
        public static void GainsOnLevelUp(Hero hero)
        {

            if (hero.GetType() == typeof(Warrior))
            {
                hero.Dexterity += 2;
                hero.Health += 30;
                hero.Intelligence += 1;
                hero.Strength += 5;
        
            }
            else if (hero.GetType() == typeof(Ranger))
            {
                hero.Dexterity += 5;
                hero.Health += 20;
                hero.Intelligence += 1;
                hero.Strength += 2;
              
            }
            else if (hero.GetType() == typeof(Mage))
            {
                hero.Dexterity += 2;
                hero.Health += 15;
                hero.Intelligence += 5;
                hero.Strength += 1;
             

            }

        }


        //The method to calculate armor level 
        public void CalculateArmorLevel(Armor armor)
        {

            if (armor.GetType() == typeof(PlateArmor))
            {
                armor.Hero.Strength = 0;
                armor.Hero.Dexterity = armor.Hero.Dexterity + (1 * armor.Hero.Level);
                armor.Hero.Intelligence = armor.Hero.Intelligence + (2 * armor.Hero.Level);
                armor.Hero.Health = armor.Hero.Health + (5 * armor.Hero.Level);
            }
            else if (armor.GetType() == typeof(LeatherArmor))
            {
                armor.Hero.Strength = armor.Hero.Strength + (1 * armor.Hero.Level);
                armor.Hero.Dexterity = armor.Hero.Dexterity + (2 * armor.Hero.Level);
                armor.Hero.Intelligence = 0;
                armor.Hero.Health = armor.Hero.Health + (8 * armor.Hero.Level);
            }

            else if (armor.GetType() == typeof(ClothArmor))
            {
                armor.Hero.Strength = 0;
                armor.Hero.Dexterity = armor.Hero.Dexterity + (1 * armor.Hero.Level);
                armor.Hero.Intelligence = armor.Hero.Intelligence + (2 * armor.Hero.Level);
                armor.Hero.Health = armor.Hero.Health + (5 * armor.Hero.Level);

            }





        }

    }
}
