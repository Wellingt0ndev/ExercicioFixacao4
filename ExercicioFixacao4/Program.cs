using ExercicioFixacao4.Entities;
using System.Globalization;
List<Person> list = new List<Person>();
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
        Console.Write("Health spending: ");
        double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        NaturalPerson naturalPerson = new NaturalPerson(name,annualIncome,healthSpending);
        list.Add(naturalPerson);
    }else if(ch == 'c')
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        LegalPerson legalPerson = new LegalPerson(name, annualIncome, employees);
        list.Add(legalPerson);
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

