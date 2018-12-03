using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MusicalInstrument :Component
    {

        public MusicalInstrument(string name)
            : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine("----" + name);
        }

    }
}
