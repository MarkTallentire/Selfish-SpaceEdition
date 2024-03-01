namespace Selfish;

public class Board(List<IPlayer> players, GameDeck gameDeck, SpaceDeck spaceDeck)
{
    private IPlayer[,] _grid = new IPlayer[players.Count, 6];


    public void Generate()
    {
        for (int i = 0; i < players.Count; i++)
        {
            _grid[i, 0] = players[i];
        }
    }

    public void Render(GameDeck gameDeck, SpaceDeck spaceDeck, int gameCardDiscardPile, int spaceCardDiscardPile)
    {
        for (var y = _grid.GetLength(1) - 1; y >= 0; y--)
        {
            for (var x = 0; x < _grid.GetLength(0); x++)
            {
                if (_grid[x, y] == null)
                {
                    Console.Write("|--|");
                }
                else
                {
                    Console.Write($"|{_grid[x, y].AstronautCard.AstronautColour}|");
                }
            }

            Console.WriteLine();
        }
        
        Console.WriteLine($"Number of Cards Remaining: {gameDeck.Cards.Count}.");
        Console.WriteLine($"Cards in Discard Pile: {gameCardDiscardPile}");
        
        Console.WriteLine($"Space deck cards remaining:{spaceDeck.Cards.Count}");
        Console.WriteLine($"Space cards in discard pile: {spaceCardDiscardPile}");
    }
}