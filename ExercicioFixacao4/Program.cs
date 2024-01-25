using ExercicioFixacao4.Entities;
using System.Globalization;
List<TaxPayer> list = new List<TaxPayer>();
Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Individual individual = new Individual(name,annualIncome,healthExpenditures);
        list.Add(individual);
    }else if(ch == 'c')
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        Company company = new Company(name, annualIncome, employees);
        list.Add(company);
    }
}
Console.WriteLine();
Console.WriteLine("TAXES PAID");
double sum = 0;
foreach (var item in list)
{
    Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
    sum += item.Tax();
}
Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

