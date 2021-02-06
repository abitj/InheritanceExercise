using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    class Reptile : Animal
    {
        public bool HasScales { set; get; }
        public bool IsColdBlooded { get; set; }
        public bool LayEggs { get; set; }

    }
}
