using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string Environment { get; set; }
        public string Defense { get; set; }
        public Reptile()
        {
        }
        public Reptile(string species, string name, int legs, string ownersName, bool isColdBlooded, bool hasScales, string environment, string defense, bool beak, bool feathers, bool fly, bool liveInTree)
        {
            Species = Species;
            Legs = Legs;
            OwnersName = ownersName;
            Name = name;
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Environment = environment;
            Defense = defense;
        }
    }
}
