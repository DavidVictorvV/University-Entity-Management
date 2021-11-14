using System;
using System.Collections.Generic;
using System.Text;

namespace University_Entity_Management
{
    class BaseEntity:IFormatter
    {
        public string Format(string text)
        {
            return text;
        }
    }
}
