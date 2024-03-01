namespace Selfish.Actions;

public class PickUpCardAction : IAction
{
    public void Perform(Game game, IPlayer player)
    {
        player.AddCardToHand(game.GameDeck.TakeTopCard());
    }
}