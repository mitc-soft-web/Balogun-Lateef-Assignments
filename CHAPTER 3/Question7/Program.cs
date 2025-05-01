System.Console.Write("Input weight of man on Earth(kg): ");
int weightOnEarth = Convert.ToInt32(Console.ReadLine());
float weightOnMoon = (17 * weightOnEarth)/100f;
System.Console.WriteLine("Weight of man on Moon(kg): "+weightOnMoon+ "kg.");