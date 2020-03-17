using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLclass
    {
        public int Divide(int Numerator, int Denominator)
        {
            if (Denominator != 0)
            {
                return Numerator / Denominator;
            }
            else
            {
                throw new DivideByZeroException("Cannot Divide by zero");
            }
        }
    }
}
