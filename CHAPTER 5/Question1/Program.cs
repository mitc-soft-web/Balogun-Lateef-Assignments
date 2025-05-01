System.Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    int tempA = b;
    b = a;
    a = tempA;
    System.Console.Write($"first and second number swapped : ({a},{b})");
}
else
{
    System.Console.WriteLine($"{a} is lesser than {b}.");
}