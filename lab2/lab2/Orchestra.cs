using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Orchestra :Component
    {
        private List<Component> groups = new List<Component>();

        public Orchestra(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            groups.Add(component);
        }

        public override void Remove(Component component)
        {
            groups.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Оркестр: " + name);
            Console.WriteLine("Групи музичних iнструментiв: ");
            foreach (Component group in groups)
            {
                group.Print();
            }
        }
    }
}
