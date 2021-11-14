using System;
using System.Collections.Generic;
using System.Text;

namespace University_Entity_Management
{
    public abstract class University
    {
        protected IFormatter _formatter;

        protected University(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public abstract void Print();
    }
}
