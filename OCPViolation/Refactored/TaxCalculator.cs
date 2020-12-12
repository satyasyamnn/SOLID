namespace OCPViolation.Refactored
{
    class TaxCalculator
    {
        private readonly ITaxCalculator _taxCalculator;

        public TaxCalculator(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public decimal CalculateTax(decimal income)
        {
            return _taxCalculator.Calculate(income);
        }
    }
}
