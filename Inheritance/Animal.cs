using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common
    class Animal
    {
        public string Name { set; get; }
        public bool HasTail { set; get; }
        public int Age { set; get; }
        public int Legs  { set; get; }

        public Animal()
        {
            Name = "Owl";
            HasTail = true;
            Age = 15;
            Legs = 2;
        }
    }
}
