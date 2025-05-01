System.Console.Write("Enter first number : ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second number : ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter third number : ");
int c = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter fourth number : ");
int d = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter fifth number : ");
int e = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c && a > d && a > e)
{
    System.Console.WriteLine($"{a} is greater than {b}, {c}, {d}, {e}.");
}
else
{
    if (b > a && b > c && b > d && b > e)
    {
        System.Console.WriteLine($"{b} is greater than {a}, {c}, {d}, {e}.");
    }
    else
    {
        if (c > b && c > a && c > d && c > e)
        {
            System.Console.WriteLine($"{c} is greater than {a}, {b}, {d}, {e}.");
        }
        else
        {
            if (d > b && d > a && d > c && d > e)
            {
                System.Console.WriteLine($"{d} is greater than {a}, {b}, {c}, {e}.");
            }
            else
            {
                System.Console.WriteLine($"{e} is greater than {a}, {b}, {c}, {d}.");
            }
        }
    }
}