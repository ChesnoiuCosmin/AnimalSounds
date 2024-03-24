using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public class Cow : Animal
    {
        public Cow()
        {
            Type = "Cow";
        }

        public override string MakeSound()
        {
            return "Moo";
        }
    }
}
