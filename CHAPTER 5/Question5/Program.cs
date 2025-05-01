System.Console.Write("Enter number(e.g 0 - 9): ");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 0:
        Console.WriteLine("selected option Zero");
        break;

    case 1:
        Console.WriteLine("selected option one");
        break;

    case 2:
        Console.WriteLine("selected option two");
        break;

    case 3:
        Console.WriteLine("selected option three");
        break;

    case 4:
        Console.WriteLine("selected option four");
        break;

    case 5:
        Console.WriteLine("selected option five");
        break;

    case 6:
        Console.WriteLine("selected option six");
        break;

    case 7:
        Console.WriteLine("selected option seven");
        break;

    case 8:
        Console.WriteLine("selected option eight");
        break;

    case 9:
        Console.WriteLine("selected option nine");

    default:
        Console.WriteLine("You have inputted an invalid number.");
        break;
}