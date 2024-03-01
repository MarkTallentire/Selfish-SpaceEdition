namespace Selfish;

public class Game
{
    private List<ICard> _discardPile = [];
    private GameDeck _gameDeck;
    private SpaceDeck _spaceDeck;
    private List<ICard> _spaceDiscardPile = [];
    
    private readonly List<IPlayer> _players;

    
    public Game(GameDeck gameDeck, SpaceDeck spaceDeckDeck, Board gameBoard, List<IPlayer> players)
    {
        _gameDeck = gameDeck;
        _spaceDeck = spaceDeckDeck;
        _players = players;
        gameBoard.Render(_gameDeck, _spaceDeck, _discardPile.Count, _spaceDiscardPile.Count);


        while (true)
        {
            foreach (var player in players)
            {
                player.AddCardToHand(_gameDeck.TakeTopCard());
                
                _spaceDeck.ReplenishIfEmpty(_spaceDiscardPile);
                _gameDeck.ReplenishIfEmpty(_discardPile);
            }
            
            gameBoard.Render(_gameDeck, _spaceDeck, _discardPile.Count, _spaceDiscardPile.Count);
        }
        
    }
  
}