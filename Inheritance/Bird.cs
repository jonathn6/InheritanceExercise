using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool Beak { get; set; }
        public bool Feathers { get; set; }
        public bool Fly { get; set; }
        public bool LiveInTree { get; set; }
        public Bird()
        {
        }
        public Bird(string species, string name, int legs, string ownersName, bool beak, bool feathers, bool fly, bool liveInTree) {
            Species = Species;
            Name = name;
            Legs = Legs;
            OwnersName = ownersName;
            Beak = beak;
            Feathers = feathers;
            Fly = fly;
            LiveInTree = LiveInTree;
        }
    }
}
