namespace OCPViolation.Refactored.TaxCalcImplementations
{
    public class UKTaxCalculator : ITaxCalculator
    {
        public decimal Calculate(decimal income)
        {
            return income * 0.2m;
        }
    }
}
