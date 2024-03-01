namespace Selfish;

public class Game
{
    private readonly List<ICard> _discardPile = new List<ICard>();
    private readonly GameDeck _gameDeck;
    private readonly SpaceDeck _space;
    private readonly List<ICard> _spaceDiscardPile = new List<ICard>();
    
    private readonly List<IPlayer> _players;

    
    public Game(GameDeck gameDeck, SpaceDeck spaceDeck, Board gameBoard, List<IPlayer> players)
    {
        _gameDeck = gameDeck;
        _space = spaceDeck;
        _players = players;
        gameBoard.Render(_gameDeck, _space, _discardPile.Count, _spaceDiscardPile.Count);
    }
}