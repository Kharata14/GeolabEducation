


//სავარჯიშო 1: მომხმარებლის კალათის ჯამი
//დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს პროდუქტების ფასი. 
//ყველა შეყვანის შემდეგ პროგრამამ მომხმარებელს უნდა ჰკითხოს სურს თუ არა გაგრძელება. 
//თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ფასის შემოყვანა. 
//ბოლოს პროგრამამ უნდა დაბეჭდოს შეყვანილი პროდუქტების საერთო ღირებულება.

/*

int price;
int sum = 0;
string next;
do
{
    Console.WriteLine("Enter price");
    price = Convert.ToInt32(Console.ReadLine());
    sum += price;
    Console.WriteLine("Do you want to continue? ('yes' or 'no')");
    next = Console.ReadLine();
} while (next == "yes");

Console.WriteLine("Products price");
Console.WriteLine(sum);

*/


//სავარჯიშო 2: საშუალო ქულის გამოთვლა
//დაწერე პროგრამა, რომელიც მოსწავლის ქულების შეყვანისას გამოთვლის საშუალო ქულას.
//პროგრამამ უნდა სთხოვოს მომხმარებელს შეიყვანოს მოსწავლის ქულები.
//ქულის შეყვანის შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება.
//თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ქულის შეყვანა.
//ბოლოს პროგრამამ უნდა დაბეჭდოს საშუალო ქულა (შეყვანილი ქულების საშუალო არითმეტიკული).

/*

int score;
int sum = 0;
int numberOfScores = 0;
string next;

do
{
    Console.WriteLine("Enter Scores");
    score = Convert.ToInt32(Console.ReadLine());
    numberOfScores++;
    sum += score;
    Console.WriteLine("Do you want to continue? ('yes' or 'no')");
    next = Console.ReadLine();
} while (next == "yes");

Console.WriteLine("Average score is:");
Console.WriteLine(sum / numberOfScores);

*/



//სავარჯიშო 3: საბანკო ანგარიშის ტრანზაქციები
//დაწერე პროგრამა, რომელიც საბანკო ანგარიშის ტრანზაქციებს ამუშავებს.
//პროგრამა მომხმარებელს სთხოვს შეიყვანოს ტრანზაქციის ტიპი (შემოსავალი ან ხარჯი) და თანხა.
//ინფორმაციის  შეყვანის შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება.
//თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ტრანზაქციის ტიპის და თანხის შეყვანა.
//საბოლოოდ პროგრამამ უნდა დაბეჭდოს ხარჯების ჯამი, შემოსავლების ჯამი და ანგარიშის ბალანსი.

/*

string transactionType;
int money;
int incomeSum = 0;
int expenseSum = 0;
int balance = 50000;
string next;

do
{
    Console.WriteLine("Enter transaction type ('income' or 'expense')");
    transactionType = Console.ReadLine();
    if (transactionType == "income")
    {
        Console.WriteLine("Enter money amount");
        money = Convert.ToInt32(Console.ReadLine());
        balance += money;
        incomeSum += money;
    }
    else if (transactionType == "expense")
    {
        Console.WriteLine("Enter money amount");
        money = Convert.ToInt32(Console.ReadLine());
        balance -= money;
        expenseSum += money;
    }
    else
    {
        Console.WriteLine("Error message");
        break;
    }
    Console.WriteLine("Do you want to continue? ('yes' or 'no')");
    next = Console.ReadLine();
} while (next == "yes");

Console.WriteLine($"Income {incomeSum}");
Console.WriteLine($"Expense {expenseSum}");
Console.WriteLine($"Balance {balance}");


*/