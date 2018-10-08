using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuvideo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chara chara = new Chara();
            auberge lafoire = new auberge();
            lafoire.nameofauberge();
            chara.intro();
            chara.name = "toto";
            chara.intro();




            System.Threading.Thread.Sleep(10000);


        }
        
    }
}
