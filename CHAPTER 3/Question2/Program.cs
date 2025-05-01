System.Console.Write("Enter number : ");
int a = Convert.Toint32(Console.ReadLine());
if (a % 5 == 0 && a % 7 == 0)
{
    System.Console.WriteLine($" {a} is divisible by 5 and 7, without a remainder .");
}
else
{
    System.Console.WriteLine($"{a} can't be divided without a remainder");
}