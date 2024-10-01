

// 1.დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით დაითვლის და დაბეჭდავს ყველა რიცხვის ჯამს 1-დან 50-მდე.

/*

int number = 1;
int sumOfNumbers = 0;

while (number <= 50)
{
    sumOfNumbers += number;
    number++;
}

Console.WriteLine(sumOfNumbers);

*/


// 2.დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით 5-ჯერ მოსთხოვს მომხმარებელს შეიყვანოს რიცხვი და დაბეჭდავს ამ რიცხვების ჯამს.

/*

int count = 0;
long sum = 0;
while (count<5)
{
    int num = Convert.ToInt32(Console.ReadLine());
    sum += num;
    count++;
}
Console.WriteLine(sum);

*/

//    DO-While Loop

// 1.დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს 10-ზე ნაკლები რიცხვი და სანამ რიცხვი არ იქნება 10-ზე ნაკლები, ისევ მოითხოვს მონაცემის შეყვანას (Do-While ციკლის გამოყენებით).

/*

int num;
Console.WriteLine("write number");
do
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 10)
    Console.WriteLine("write number under 10");
} while (num > 10);

*/


// 2.დაწერე პროგრამა, რომელიც 3-ჯერ დაუსვამს მომხმარებელს კითხვას "Do you want to continue?" და თუ პასუხი იქნება "yes", პროგრამა გააგრძელებს ციკლს.


/*

int count = 0;
string answer;

do
{
    Console.WriteLine("do you want to continue?");
    answer = Console.ReadLine();
    if (answer == "yes")
    {
        count--;
    }
        count++;

} while (count <= 2);


*/




