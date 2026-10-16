using System;

namespace Polimorfisme
{
    
    public class MainClass
    {
        
        public static void Main(string[] args)
        {

            Knight k = new Knight();
            k.baseDamage = 100;
            k.name = "Nishi";
            k.bonusArmor = 50;

            Wizard w = new Wizard();
            w.baseDamage = 80;
            w.name = "Tania";
            w.bonusMagic = 150;

            CalculateTotalDamage(k);
            CalculateTotalDamage(w);

        }

        public static void CalculateTotalDamage(Hero h)
        {

            if (h is Knight)
            {
                
                Knight k = (Knight)h;
                int total = k.baseDamage + k.bonusArmor;
                Console.WriteLine("Total Damage Knight = " + total);

            }

            else if (h is Wizard)
            {
                
                Wizard w = (Wizard)h;
                int total = w.baseDamage + w.bonusMagic;
                Console.WriteLine("Total Damage Wizard = " +total);
                
            }
            /*
            Hero h = new Hero();
            h = new Knight();
            h = new Wizard();

            Knight k = new Knight();
            k.baseDamage = 100;
            k.name = "Shido";
            k.bonusArmor = 50;

            h = k;
            h.UseSkill();

            k.UseSkill();

            Hero[] arrHero = new Hero[3];
            Knight kn = new Knight();
            kn.name = "Lance";
            kn.baseDamage = 120;
            kn.bonusArmor = 80;

            arrHero[0] = h;
            arrHero[1] = k;
            arrHero[2] = new Wizard();

            arrHero[0].UseSkill();
            arrHero[1].UseSkill();
            arrHero[2].UseSkill();
            */

        }
    }
}
