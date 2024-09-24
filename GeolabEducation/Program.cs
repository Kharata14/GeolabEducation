
Console.WriteLine("Enter age");
int age = int.Parse(Console.ReadLine());


if(age < 18)
{
    Console.WriteLine("Your age is under 18");
    return;
}

Console.WriteLine("Enter wage");
decimal wage = decimal.Parse(Console.ReadLine());

if (age >= 18 && wage >= 25000)
{
    Console.WriteLine("Loan granted");
}
else if (age >= 18 && wage < 25000)
{
    Console.WriteLine("Not enough amount of wage for loan");
    Console.WriteLine("Do you have an accomplice?");
    string accomplice = Console.ReadLine();
    while (accomplice != "yes" &&  accomplice != "no" && accomplice != "Yes" && accomplice != "No")
    {
        Console.WriteLine("Enter valid answer ('yes' or 'no')");
    }
    if (accomplice == "yes" || accomplice == "Yes")
    {
        Console.WriteLine("Loan granted");
    }
    else if (accomplice == "no" ||  accomplice == "No")
    {
        Console.WriteLine("Not enough amount of wage for loan");
    }
}


