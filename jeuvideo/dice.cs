using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuvideo
{
    class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        public int Throwdice()
        {
            return random.Next(0, 100);
        }
    }
}
