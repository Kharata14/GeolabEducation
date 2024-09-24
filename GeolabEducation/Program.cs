
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

/*

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
*/

//7. მარტივი კალკულატორი

/*

Console.WriteLine("Enter Number");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Operator");
string operation = Console.ReadLine();

Console.WriteLine("Enter number");
int number2 = int.Parse(Console.ReadLine());

if (operation == "+")
{
    Console.WriteLine(number1 + number2);
}
else if (operation == "-")
{
    Console.WriteLine(number1 - number2);
}
else if (operation == "*")
{
    Console.WriteLine(number1 * number2);
}
else if (operation == "/")
{
    Console.WriteLine(number1 / number2);
}

*/

//8. არჩევნების უფლებამოსილება

/*

Console.WriteLine("Enter your age");

int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You can participate in the elections");
}
else
{
    Console.WriteLine("Your age is below 18, You can't participate in the elections");
}

*/


//9.დღის მისალმება საათის მიხედვით

/*

DateTime currentTime = DateTime.Now;

if(currentTime.Hour >= 5 && currentTime.Hour < 12)
{
    Console.WriteLine("Good Morning");
}
else if(currentTime.Hour >= 12 && currentTime.Hour < 15)
{
    Console.WriteLine("Good Afternoon");
}
else if(currentTime.Hour >= 17 && currentTime.Hour < 21)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
}

*/

//10.შოპინგის ფასდაკლების კალკულატორი


decimal cash = decimal.Parse(Console.ReadLine());
decimal percent;

if (cash <= 0)
{
    Console.WriteLine("Enter valid amount");
}
else if (cash < 100)
{
    Console.WriteLine("No discount");
}
else if (cash > 99 && cash < 500)
{
    percent = cash * 10 / 100;
    cash = cash - percent;
    Console.WriteLine($"Paid money {cash}$");
    Console.WriteLine($"Discount amount {percent}$");
}
else if (cash > 500)
{
    percent = cash * 20 / 100;
    cash = cash - percent;
    Console.WriteLine($"Paid money {cash}$");
    Console.WriteLine($"Discount amount {percent}$");
}


