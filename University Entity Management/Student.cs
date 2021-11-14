using System;
using System.Collections.Generic;
using System.Text;

namespace University_Entity_Management
{
    public class Student: Manuscript
    {
        private string _name, _year;

        public Student(IFormatter formatter)
            : base(formatter)
        {

        }

        public Student SetName(string name)
        {
            _name = name;
            return this;
        }


        public Student SetYear(string year)
        {
            _year = year;
            return this;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {_formatter.Format(_name)}");
            Console.WriteLine($"Year: {_formatter.Format(_year)}" );
        }
    }
}
