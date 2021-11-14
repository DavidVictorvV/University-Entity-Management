using System;
using System.Collections.Generic;
using System.Text;

namespace University_Entity_Management
{
    public abstract class Manuscript
    {
        protected IFormatter _formatter;

        protected Manuscript(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public abstract void Print();
    }
}
