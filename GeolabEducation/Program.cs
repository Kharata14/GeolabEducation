

//3. შეფასების კატეგორიზაცია

Console.WriteLine("Enter your score");
int score = int.Parse(Console.ReadLine());

if (score > 100)
{
    Console.WriteLine("Enter valid score");
}

if (score < 0)
{
    Console.WriteLine("Enter valid score");
}

if (score > 89 && score < 101)
{
    Console.WriteLine("A");
}
else if (score > 79 && score < 90)
{
    Console.WriteLine("B");
}
else if (score > 69 && score < 80)
{
    Console.WriteLine("C");
}
else if (score > 59 && score < 70)
{
    Console.WriteLine("D");
}
else if (score > 0 && score < 60)
{
    Console.WriteLine("F");
}