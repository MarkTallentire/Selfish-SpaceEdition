namespace Selfish;

public interface IGameCard : ICard
{
    public void Use(Game game, IPlayer player);
}

class SingleOxygen : IGameCard
{
    public CardType CardType { get; } = CardType.SingleOxygen;
    
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }
}

class DoubleOxygen : IGameCard
{
    public CardType CardType { get; } = CardType.DoubleOxygen;
    
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }
}


public class OxygenSiphon : IGameCard
{
    public CardType CardType { get; } = CardType.Game;
    
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }
}

public class Shield : IGameCard
{
    public CardType CardType { get; } = CardType.Game;
    
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }
}

public class HackSuit: IGameCard
{
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }

    public CardType CardType { get; } = CardType.Game;
}


public class TractorBeam: IGameCard
{
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }

    public CardType CardType { get; } = CardType.Game;
}

public class RocketBooster: IGameCard
{
    public void Use(Game game, IPlayer player)
    {
        game.GameBoard.MovePlayer(1, player);
        player.Hand.Remove(this);
        game.AddCardToDiscardPile(this);
    }

    public CardType CardType { get; } = CardType.Game;
}

public class LaserBlast: IGameCard
{
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }

    public CardType CardType { get; } = CardType.Game;
}

public class HoleInSuit : IGameCard
{
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }

    public CardType CardType { get; } = CardType.Game;
}

public class Tether : IGameCard
{
    public void Use(Game game, IPlayer player)
    {
        Console.WriteLine("Card action not yet implemented");
    }

    public CardType CardType { get; } = CardType.Game;
}