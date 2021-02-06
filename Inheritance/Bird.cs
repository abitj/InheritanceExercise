using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    class Bird : Animal
    {
        public bool HasWings { set; get; }
        public bool HasBackBone { set; get; }
        public bool HasFeathers { set; get; }
        public string Type { set; get; }
    }
}
