using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animals
    {
        public Bird()
        { }

        public string Beak { get; set; }
        public int Wings { get; set; }
        public bool Feathers { get; set; }
        public bool Flight { get; set; }

    }
}
