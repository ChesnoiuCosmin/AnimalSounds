using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public abstract class Animal
    {
        public string Type { get; set; }
        public abstract string MakeSound();
    }
}
