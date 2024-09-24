
Console.WriteLine("Enter country");
string country = Console.ReadLine();
Console.WriteLine("Enter age");
int age = int.Parse(Console.ReadLine());

if (country == "usa" || country == "USA" || country == "Usa" && age >= 21)
{
    Console.WriteLine("Purchase is allowed");
}
else if (country != "usa" || country == "USA" || country == "Usa" && age >= 18)
{
    Console.WriteLine("Purchase is allowed");
}
else
{
    Console.WriteLine("Purchase is prohibited");
}
