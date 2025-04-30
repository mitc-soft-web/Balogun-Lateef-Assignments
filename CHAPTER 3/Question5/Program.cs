System.Console.Write("Enter the first number(e.g 14): ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number(e.g 30): ");
int b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i < b; i++)
{
    if (i % 5 == 0)
    {
       string amount= (string)i.count;
       System.Console.WriteLine(i);
       System.Console.WriteLine(amount); 
    }
    
}