using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class GroupOfMusicalInstruments :Component
    {

        private List<Component> instruments = new List<Component>();

        public GroupOfMusicalInstruments(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            instruments.Add(component);
        }

        public override void Remove(Component component)
        {
            instruments.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("--Група музичних iнструментiв: " + name);
            Console.WriteLine("----Музичнi iнструменти: ");
            foreach (Component musicalInstrument in instruments)
            {
                musicalInstrument.Print();
            }
        }
    }
}
