System.Console.Write("Enter Co-efficient(a) : ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter Co-efficient(b) : ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter Co-efficient(c) : ");
int c = Convert.ToInt32(Console.ReadLine());

int D = -b -((b*b) - 4*(a*c));
int d = -b + ((b*b) - 4*(a*c));
if (D == 0)
{
    float x = -b/(2f*a);
    System.Console.WriteLine($"The Quadractic Equation has one double root : {x}");
}
else
{
    if (D > 0)
    {
        float q = d/(2f*a);
        float x = D/(2f*a);
        System.Console.WriteLine($"The Quadractic Equation has two roots : {x} and {q}.");
    }
    System.Console.WriteLine("The Quadractic Equation has no real root.");
}