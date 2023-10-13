namespace MyProject.Utilities{
class GameAccount
{
    private string userName;
    private int currentRating;
    private int gamesCount;
    private List<Game> gameHistory;

    public GameAccount(string userName)
    {
        this.userName = userName;
        currentRating = 1;
        gamesCount = 0;
        gameHistory = new List<Game>();
    }

    public void WinGame(string opponentName, int rating)
    {
        if (rating < 0)
        {
            throw new ArgumentException("Rating cannot be negative.");
        }

        currentRating += rating;
        gamesCount++;
        gameHistory.Add(new Game { OpponentName = opponentName, Rating = rating, Win = true });
    }

    public void LoseGame(string opponentName, int rating)
    {
        if (rating < 0)
        {
            throw new ArgumentException("Rating cannot be negative.");
        }

        if (currentRating - rating < 1)
        {
            currentRating = 1;
        }
        else
        {
            currentRating -= rating;
        }

        gamesCount++;
        gameHistory.Add(new Game { OpponentName = opponentName, Rating = rating, Win = false });
    }

    public void GetStats()
    {
        Console.WriteLine($"Stats for {userName}:");
        for (int i = 0; i < gameHistory.Count; i++)
        {
            string result = gameHistory[i].Win ? "Win" : "Lose";
            Console.WriteLine($"Round {i + 1}: Opponent - {gameHistory[i].OpponentName}, Result - {result}, Rating change - {gameHistory[i].Rating}");
        }
        Console.WriteLine($"Amount of played games: {gamesCount}, Current rating: {currentRating}");
    }
}
}