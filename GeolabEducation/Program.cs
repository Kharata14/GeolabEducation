
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

/*
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
*/


//6. სამი რიცხვიდან ყველაზე დიდის პოვნა

Console.WriteLine("Enter Number 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Number 2");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 3");
int number3 = int.Parse(Console.ReadLine());

if (number1 >= number2 && number1 >= number3)
{
    Console.WriteLine("Largest number");
    Console.WriteLine(number1);
}
else if (number2 >= number1 && number2 >= number3)
{
    Console.WriteLine("Largest number");
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Largest number");    
    Console.WriteLine(number3);
}
