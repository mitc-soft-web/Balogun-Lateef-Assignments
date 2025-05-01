System.Console.Write("Input x-coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input y-coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());
int r = 5;

if (x*x + y*y <= r*r)
{
    System.Console.WriteLine("The Triangle is within the Circle.");
}
else
{
    System.Console.WriteLine("The Triangle is outside the Circle.");
}
