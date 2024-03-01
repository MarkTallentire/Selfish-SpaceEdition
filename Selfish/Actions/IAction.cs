namespace Selfish.Actions;

public interface IAction
{
    void Perform(Game game, IPlayer player);
}