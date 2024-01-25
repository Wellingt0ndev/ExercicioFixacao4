
namespace ExercicioFixacao4.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            NumberOfEmployees = employees;
        }

        public override double Tax()
        {
            int percentual;
            if(NumberOfEmployees > 10)
            {
                percentual = 14;
            }
            else
            {
                percentual = 16;
            }
            return AnnualIncome * percentual/100;
        }
    }
}
