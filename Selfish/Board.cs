namespace Selfish;

public class Board(List<IPlayer> players, GameDeck gameDeck, SpaceDeck spaceDeck)
{
    public IPlayer[,] Grid { get; } = new IPlayer[players.Count, 6];


    public void Generate()
    {
        for (int i = 0; i < players.Count; i++)
        {
            Grid[i, 0] = players[i];
        }
    }

    public void MovePlayer(int spaces, IPlayer player)
    {
        for (int row = 0; row < Grid.GetLength(0); row++)
            for (int col = 0; col < Grid.GetLength(1); col++)
                if (Grid[row, col] == player)
                {
                    Grid[row, col + 1] = player;
                    Grid[row, col] = null;
                    return;
                }
    }

    public void Render(GameDeck gameDeck, SpaceDeck spaceDeck, int gameCardDiscardPile, int spaceCardDiscardPile)
    {
        int longestColor = 0;
        foreach (var color in Enum.GetValues<AstronautColour>())
        {
            var length = color.ToString().Length;
            if (length > longestColor)
            {
                longestColor = length;
            }
        }

        longestColor += 8; //Add 8 to account for (Dead)
        
        for (var y = Grid.GetLength(1) - 1; y >= 0; y--)
        {
            for (var x = 0; x < Grid.GetLength(0); x++)
            {
                if (Grid[x, y] == null)
                {
                    Console.Write("|");
                    AddPadding(longestColor);
                    Console.Write("|");
                }
                else
                {
                    var astronautColour = Grid[x, y].AstronautCard.AstronautColour.ToString();
                    if (Grid[x, y].IsDead)
                        astronautColour += " (Dead)";
                    var paddingSize = (longestColor - astronautColour.Length) / 2;

                    Console.Write("|");
                    AddPadding(paddingSize);
                    Console.Write(astronautColour);
                    AddPadding(longestColor - astronautColour.Length - paddingSize);
                    Console.Write("|");

                    
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Number of Cards Remaining: {gameDeck.Cards.Count}.");
        Console.WriteLine($"Cards in Discard Pile: {gameCardDiscardPile}");

        Console.WriteLine($"Space deck cards remaining:{spaceDeck.Cards.Count}");
        Console.WriteLine($"Space cards in discard pile: {spaceCardDiscardPile}");
    }

    private void AddPadding(int spaces)
    {
        for (int i = 0; i < spaces; i++)
        {
            Console.Write(" ");
        }
        
    }
}