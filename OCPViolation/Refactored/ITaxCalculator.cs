using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.Refactored
{
    interface ITaxCalculator
    {
        decimal Calculate(decimal income);
    }
}
