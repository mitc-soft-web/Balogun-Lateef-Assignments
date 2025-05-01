System.Console.Write("Enter number (3- digits or more): ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 100 % 10 ;
if (a == 7)
{
    System.Console.WriteLine(" The third digit (right - left) is 7.");
}
else
{
    System.Console.WriteLine("7 is not the third digit (right - left).");
}