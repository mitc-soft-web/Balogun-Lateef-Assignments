System.Console.Write("Enter number (3- digits or more): ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 100;
int check = (a % 10 == 7);
System.Console.WriteLine(check);