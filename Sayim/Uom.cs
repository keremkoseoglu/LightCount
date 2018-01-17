using System;
using System.Collections.Generic;
using System.Text;

namespace Sayim
{
    public class Uom
    {
        public string intCode;
        public string extCode;

        public Uom(string Internal, string External)
        {
            intCode = Internal;
            extCode = External;
        }
    }
}
