using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuvideo
{
     class Chara
    {
       public bool Isalive { get; private set; }
       public Dice dice;
       public String name { get; set; }
       public Stats stats ;
       
       public Chara()
        {
            name = "creature";
            Isalive = true;
        }

        public void intro()

        {
            Console.WriteLine("je m'appelle " + name + "et je suis un chara");
        }
        
        public void attac()
        {

        }
        public void takedommage()
        {
            int throwdiceagi = dice.Throwdice();

            if (throwdiceagi < Agility)    // si le lancer de dé est inferieur a l'agile il esquive
            {
                Console.WriteLine("esquive");
            }
            else
            {

            }
        }
    }
       
    
}
