
namespace ExercicioFixacao4.Entities
{
    internal class NaturalPerson : Person
    {
        public double HealthSpending { get; set; }

        public NaturalPerson() { }

        public NaturalPerson(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
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
            
            return (AnnualIncome * percentual/100) - (HealthSpending*50/100);
        }
    }
}
