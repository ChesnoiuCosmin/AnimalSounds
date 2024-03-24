using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public class Cat : Animal
    {
        public Cat()
        {
            Type = "Cat";
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
