namespace Selfish;

public class Board(List<IPlayer> players, Deck gameDeck)
{
    private IPlayer[,] _grid = new IPlayer[players.Count, 6];
    private List<ICard> _discardPile = new List<ICard>();
    private Deck _gameDeck = gameDeck;

    public void Generate()
    {
        for (int i = 0; i < players.Count; i++)
        {
            _grid[i, 0] = players[i];
        }
    }

    public void Render()
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
        
        Console.WriteLine($"Number of Cards Remaining: {_gameDeck.Cards.Count()}.");
        Console.WriteLine($"Cards in Discard Pile: {_discardPile.Count}");
    }
}