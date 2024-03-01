namespace Selfish.Actions;

public class PlayActionCard(IGameCard card) : IAction
{
    public void Perform(Game game, IPlayer player)
    {
        player.Hand.Remove(card);
        card.Use(game, player);
        Console.WriteLine("Player played " + card.GetType().Name);
    }
}