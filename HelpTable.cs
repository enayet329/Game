using System;
using System.Collections.Generic;

public class HelpTable
{
    private readonly List<string> moves;

    public HelpTable(List<string> moves)
    {
        this.moves = moves;
    }

    public void DisplayHelpTable()
    {
        int n = moves.Count;
        int columnWidth = 8;


        PrintRowBorder(n, columnWidth);


        Console.Write("| v PC\\User >".PadRight(columnWidth));
        for (int i = 0; i < n; i++)
        {
            Console.Write($"| {TruncateOrPad(moves[i], columnWidth - 1)} ");
        }
        Console.WriteLine("|");


        PrintRowBorder(n, columnWidth);


        for (int i = 0; i < n; i++)
        {
            Console.Write($"| {TruncateOrPad(moves[i], columnWidth - 1)} ");
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    Console.Write($"| {"Draw".PadRight(columnWidth - 2)} ");
                }
                else if ((i - j + n) % n <= n / 2 && (i - j + n) % n != 0)
                {
                    Console.Write($"| {"Win".PadRight(columnWidth - 2)} ");
                }
                else
                {
                    Console.Write($"| {"Lose".PadRight(columnWidth - 2)} ");
                }
            }
            Console.WriteLine("|");


            PrintRowBorder(n, columnWidth);
        }
    }

    private void PrintRowBorder(int n, int columnWidth)
    {
        Console.Write("+".PadRight(columnWidth, '-'));
        for (int i = 0; i < n; i++)
        {
            Console.Write("+".PadRight(columnWidth, '-'));
        }
        Console.WriteLine("+");
    }

    private string TruncateOrPad(string text, int length)
    {
        if (text.Length > length)
        {
            return text.Substring(0, length - 1) + ".";
        }
        return text.PadRight(length);
    }
}
