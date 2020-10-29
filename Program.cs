using System;
using System.Reflection.Metadata;

namespace rpg
{

    class DmgCalc
    {
        public static int DmgA(Hero atkr, Hero trgt)
        {

            int dmg = 1;
            float damage = atkr.ATK - trgt.DEF;
            if (damage < 1f)
            {
                damage = 1f;
            }
            return dmg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int h, d, a;

            Console.Write("Knight HP = ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Knight DEF = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Knight attack = ");
            a = int.Parse(Console.ReadLine());
            var hero1 = new Hero(h, d, a);

            Console.Write("Archer HP = ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Archer Def = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Archer attack = ");
            a = int.Parse(Console.ReadLine());
            var hero2 = new Hero(h, d, a);

            

            do
            {                
                if (hero1.HP > 0) 
                {
                    int dmg1 = DmgCalc.DmgA(hero1, hero2);
                    Console.WriteLine("Knight attacks: " + dmg1);
                    hero2.HP -= dmg1; 
                }
                Console.WriteLine("Archer HP = " + (hero2.HP));

               
                if (hero2.HP > 0) 
                {
                    int dmg2 = DmgCalc.DmgA(hero2, hero1);
                    Console.WriteLine("Archer attacks: " + dmg2);
                    hero1.HP -= dmg2; 
                }
                Console.WriteLine("Knight HP = " + (hero1.HP));

            } while (hero1.HP > 0 && hero2.HP > 0);

            Console.WriteLine("=================");
            Console.WriteLine("Knight HP = " + hero1.HP);
            Console.WriteLine("Archer = " + hero2.HP);
            if (hero1.HP > 0) { Console.WriteLine("Knight wins!"); }
            else Console.WriteLine("Archer wins!");
        }
       
    }

    class Hero
    {
        public int HP;
        public int DEF;
        public int ATK;

        public Hero(int HP, int DEF, int ATK)
        {            
            this.HP = HP;
            this.DEF = DEF;
            this.ATK = ATK;
        }
              
    }

   
    
}





