using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    struct Stuff
    {
        public int IntenStuff { get; }
        public double DoubStuff { get; }
        public bool BooStuff { get; }

        public Stuff(int a, double b, bool c) 
        {
            IntenStuff = a;
            DoubStuff = b;
            BooStuff = c;

        }


    }
}
