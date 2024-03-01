using System.Threading.Tasks.Dataflow;
using Selfish.Actions;

namespace Selfish;

public class Game
{
    public List<ICard> DiscardPile { get; } = [];
    public GameDeck GameDeck { get; }
    private SpaceDeck _spaceDeck;
    private List<ICard> _spaceDiscardPile = [];
    
    public Board GameBoard { get; }
    
    private readonly List<IPlayer> _players;

    
    public Game(GameDeck gameDeck, SpaceDeck spaceDeckDeck, Board gameBoard, List<IPlayer> players)
    {
        GameDeck = gameDeck;
        _spaceDeck = spaceDeckDeck;
        _players = players;
        GameBoard = gameBoard;
        
        gameBoard.Render(GameDeck, _spaceDeck, DiscardPile.Count, _spaceDiscardPile.Count);


        while (true)
        {
            if (players.All(x => x.IsDead)) GameOver();
            foreach (var player in players)
            {
                if (player.IsDead) continue;
                var action = new PickUpCardAction();
                action.Perform(this, player);

                var secondAction = new PlayActionCard(player.Hand[0]);
                    secondAction.Perform(this, player);
                
                CheckIfPlayerHasDied(player);
                CheckForPlayerWin(gameBoard, player);
                ReplenishDecks();
            }
            
            players[0].Kill();
            
            gameBoard.Render(GameDeck, _spaceDeck, DiscardPile.Count, _spaceDiscardPile.Count);
        }
    }

    private void CheckForPlayerWin(Board board, IPlayer player)
    {
        for (int row = 0; row < board.Grid.GetLength(0); row++)
        {
            if (board.Grid[row, 5] != null)
            {
                GameBoard.Render(GameDeck, _spaceDeck, DiscardPile.Count, _spaceDiscardPile.Count);
                Console.WriteLine($"{player.AstronautCard.AstronautColour} Wins!");
                Environment.Exit(0);
            }
        }
    }

    public void AddCardToDiscardPile(ICard card)
    {
        DiscardPile.Add(card);
    }

    private void ReplenishDecks()
    {
        _spaceDeck.ReplenishIfEmpty(_spaceDiscardPile);
        GameDeck.ReplenishIfEmpty(DiscardPile);
    }

    private static void CheckIfPlayerHasDied(IPlayer player)
    {
        if (!player.Hand.Any(x => x.CardType == CardType.SingleOxygen || x.CardType == CardType.DoubleOxygen))
        {
            player.Kill();
        }
    }

    private void GameOver()
    {
        GameBoard.Render(GameDeck, _spaceDeck, DiscardPile.Count, _spaceDiscardPile.Count);
        Console.WriteLine("Alas, the game is over and all have perished. Turns out team work really does make the dream work");
        Environment.Exit(0);
    }
}