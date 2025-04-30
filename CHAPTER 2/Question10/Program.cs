System.Console.Write("Input 4-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number/1000, tempB = number/100, b = tempB%10, tempC = number%100, c = tempC/10, d = number%10;

int sumOfDigits = a + b + c + d;
System.Console.WriteLine($"Sum of the 4-digits = {sumOfDigits}.");

int reversedDigits = d + c + b + a;
System.Console.WriteLine($"The Reversed Order of the 4-digit Number = {reversedDigits}.");

System.Console.WriteLine($"The Re-arranged 4-digits: {d}{a}{b}{c}.");

System.Console.WriteLine($"{a}{c}{b}{d} - Swapped the second and third digit.");