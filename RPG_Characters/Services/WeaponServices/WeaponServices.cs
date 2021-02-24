using RPG_Characters.Models.Heros;
using RPG_Characters.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Services.WeaponService
{
    class WeaponServices
    {
        public Hero hero { get; set; }
        Weapon weapon { get; set; }

        public WeaponServices(Hero hero,Weapon weapon)
        {
           this.hero = hero;
            this.weapon = weapon;

        }

      


        public  int CalculateDamageAttack()
        {
            int result;
            if (this.weapon.GetType() == typeof(MagicWeapon)) { 
                result = this.weapon.Damage + (this.hero.Intelligence * 3); }

            else if (this.weapon.GetType() == typeof(RangedWeapon))
            {
                result = this.weapon.Damage + (this.hero.Dexterity * 2);
            }

            else if (this.weapon.GetType() == typeof(MeleeWeapon))
            {
                result = (int)(this.weapon.Damage + (this.hero.Strength * 1.5));
            }
            else
            {
                throw new Exception("It is not a weapon");
            }
            return result;

        }

 
        public  void CalculateDamage()
        {
            if (this.weapon.GetType() == typeof(MagicWeapon) || this.weapon.GetType() == typeof(MeleeWeapon))
            {
                this.weapon.Damage = this.weapon.Damage+(2 * this.hero.Level) ;
            }
            else if (this.weapon.GetType() == typeof(RangedWeapon))
            {
                this.weapon.Damage = this.weapon.Damage + (3 * this.hero.Level);
            }
            else
            {
                throw new Exception("It is not a weapon");
            }

        }
    }
}
