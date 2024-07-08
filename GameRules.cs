

public class GameRules
{
    private readonly List<string> moves;

    public GameRules(List<string> moves)
    {
        this.moves = moves;
    }

    public string DetermineWinner(string userMove, string computerMove)
    {
        int userIndex = moves.IndexOf(userMove);
        int computerIndex = moves.IndexOf(computerMove);

        if (userIndex == computerIndex)
        {
            return "Draw";
        }
        else if ((computerIndex - userIndex + moves.Count) % moves.Count <= moves.Count / 2)
        {
            return "Computer wins";
        }
        else
        {
            return "User wins";
        }
    }
}
