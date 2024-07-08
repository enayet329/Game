
public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 3 || args.Length % 2 == 0)
        {
            Console.WriteLine("Error: Provide an odd number of moves greater than 1.");
            return;
        }

        if (args.Distinct().Count() != args.Length)
        {
            Console.WriteLine("Error: Moves must be unique.");
            return;
        }

        List<string> moves = new List<string>(args);
        Game game = new Game(moves);
        game.Start();
    }
}
