System.Console.Write("Enter first number : ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second number : ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter third number : ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    System.Console.WriteLine($"{a} is greater than {b} and {c}.");
}
else
{
    if (b > a && b > c)
    {
        System.Console.WriteLine($"{b} is greater than {a} and {c}.");
    }
    System.Console.WriteLine($"{c} is greater than {a} and {b}");
}