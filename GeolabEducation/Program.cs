
//1. შემოწმება, რიცხვი დადებითია თუ უარყოფითი

/*
Console.WriteLine("Enter Number");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Number is positive");
}
else if (number == 0)
{
    Console.WriteLine("Number is zero");
}
else
{
    Console.WriteLine("Numebr is Negative");
}

*/



//2. შემოწმება, რიცხვი ლუწია თუ კენტი

Console.WriteLine("Enter Number");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd");
}
