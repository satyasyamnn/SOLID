using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation
{
    public enum Country
    {
        UK,
        USA,
        INDIA
    }


    public class Accountant
    {
        private readonly Country _country;

        public Accountant(Country country)
        {
            _country = country;
        }

        public decimal CalculateTax(decimal income)
        {
            switch (_country)
            {
                case Country.UK:
                    return income * 0.2m;
                case Country.USA:
                    return income * 0.25m;
            }
            throw new ArgumentException("Country income tax is not supported");
        }
    }
}
