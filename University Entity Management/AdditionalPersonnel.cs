using System;
using System.Collections.Generic;
using System.Text;

namespace University_Entity_Management
{
    public class AdditionalPersonnel : University
    {
        private string _name, _role;

        public AdditionalPersonnel(IFormatter formatter)
            : base(formatter)
        {

        }

        public AdditionalPersonnel SetName(string name)
        {
            _name = name;
            return this;
        }


        public AdditionalPersonnel SetRole(string role)
        {
            _role = role;
            return this;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {_formatter.Format(_name)}");
            Console.WriteLine($"Role: {_formatter.Format(_role)}" );
        }
    }
}
