
namespace ExercicioFixacao4.Entities
{
    internal class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson() { }

        public LegalPerson(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            int percentual;
            if(Employees > 10)
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
