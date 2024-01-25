
namespace ExercicioFixacao4.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            int percentual;
            if(AnnualIncome < 2000.00)
            {
                percentual = 15;
            }
            else
            {
                percentual = 25;
            }
            
            return (AnnualIncome * percentual/100) - (HealthExpenditures*50/100);
        }
    }
}
