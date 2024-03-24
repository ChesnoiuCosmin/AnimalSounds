using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public class Goat : Animal
    {
        public Goat()
        {
            Type = "Goat";
        }

        public override string MakeSound()
        {
            return "Bee";
        }
    }
}
