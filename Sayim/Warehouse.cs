using System;
using System.Collections.Generic;
using System.Text;

namespace Sayim
{
    public class Warehouse
    {
        public string code, text;

        public Warehouse()
        {
            code = "";
            text = "";
        }

        public Warehouse(string Code, string Text)
        {
            code = Code;
            text = Text;
        }

        public override string ToString()
        {
            return code + " - " + text;
        }
    }
}
