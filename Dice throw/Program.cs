Random random = new Random();
int dicethrow = random.Next(1, 7);

switch (dicethrow)
{
    case 1:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You hit a one!");
        break;
    case 2:
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("You hit a two");
        break;
    case 3:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You hit a three!");
        break;
    case 4:
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You hit a four!");
        break;
    case 5:
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You hit a five!");
        break;
    case 6:
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You hit a six!");
        break;

    default:
        break;


        
}
Console.ReadKey();