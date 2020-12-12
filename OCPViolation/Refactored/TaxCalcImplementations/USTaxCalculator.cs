namespace OCPViolation.Refactored.TaxCalcImplementations
{
    class USTaxCalculator : ITaxCalculator
    {
        public decimal Calculate(decimal income)
        {
            return income * 0.25m;
        }
    }
}
