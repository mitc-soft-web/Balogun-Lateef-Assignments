System.Console.Write("Enter score(1 - 9) : ");
int score = Convert.ToInt32(Console.ReadLine());

if (1 <= score && score <= 3)
{
    int a = score * 10;
    System.Console.WriteLine($"{score} : {a}");
}
else
{
    if (4 <= score && score <= 6)
    {
        int b = score * 100;
        System.Console.WriteLine($"{score} : {b}");
    }
    else
    {
        if (7 <= score && score <= 9)
        {
            int c = score * 1000;
            System.Console.WriteLine($"{score} : {c}");
        }
        else
        {
            if(1 < score && score > 9)
            {
                System.Console.WriteLine("Error! Invalid score!");
            }
        }
    }
}