using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile: Animals
    {
       public  Reptile()
        {    }

        public bool Claws { get; set; }
        public bool Scales { get; set; }
        public bool Tongue { get; set; }

        public bool Tail { get; set; }


    }
}
