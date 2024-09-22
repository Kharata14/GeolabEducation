

Console.WriteLine("Enter Password");

string password = "secret123";

string passwordCheck = Console.ReadLine();

if (passwordCheck == password)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Forbidden");
}

