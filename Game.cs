using System;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    private readonly List<string> moves;
    private readonly GameRules gameRules;
    private readonly HelpTable helpTable;
    private readonly Random random;

    public Game(List<string> moves)
    {
        this.moves = moves;
        this.gameRules = new GameRules(moves);
        this.helpTable = new HelpTable(moves);
        this.random = new Random();
    }

    public void Start()
    {
        byte[] key = CryptoUtils.GenerateKey();
        string computerMove = moves[random.Next(moves.Count)];
        string hmac = CryptoUtils.CalculateHMAC(computerMove, key);

        Console.WriteLine("HMAC: " + hmac);
        Console.WriteLine("Available moves:");
        for (int i = 0; i < moves.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {moves[i]}");
        }
        Console.WriteLine("0 - exit");
        Console.WriteLine("? - help");

        while (true)
        {
            Console.Write("Enter your move: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else if (input == "?")
            {
                helpTable.DisplayHelpTable();
            }
            else
            {
                try
                {
                    int userMoveIndex = int.Parse(input) - 1;
                    if (userMoveIndex >= 0 && userMoveIndex < moves.Count)
                    {
                        string userMove = moves[userMoveIndex];
                        Console.WriteLine("Your move: " + userMove);
                        Console.WriteLine("Computer move: " + computerMove);
                        Console.WriteLine(gameRules.DetermineWinner(userMove, computerMove));
                        Console.WriteLine("HMAC key: " + Convert.ToBase64String(key));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. Try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}
