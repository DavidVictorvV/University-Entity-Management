using System;
using System.Collections.Generic;
using System.Text;

namespace University_Entity_Management
{
    public class Professor: University
    {
        private string _name, _spec;

        public Professor(IFormatter formatter)
            : base(formatter)
        {

        }

        public Professor SetName(string name)
        {
            _name = name;
            return this;
        }


        public Professor SetSpec(string spec)
        {
            _spec = spec;
            return this;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {_formatter.Format(_name)}");
            Console.WriteLine($"Spec: {_formatter.Format(_spec)}" );
        }
    }
}
