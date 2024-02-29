namespace Selfish;

public interface IGameCard : ICard
{
    public void Use();
}

class OxygenCard : ICard, IGameCard
{
    public CardType CardType { get; } = CardType.Oxygen;
    public int Value { get; } = 0;

    public OxygenCard(int value)
    {
        Value = value;
    }

    public void Use()
    {
        throw new NotImplementedException();
    }
}


public class OxygenSiphon : IGameCard, ICard
{
    public CardType CardType { get; } = CardType.Game;
    
    public void Use()
    {
        throw new NotImplementedException();
    }
}

public class Shield : IGameCard, ICard
{
    public CardType CardType { get; } = CardType.Game;
    
    public void Use()
    {
        throw new NotImplementedException();
    }
}

public class HackSuit: IGameCard, ICard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}


public class TractorBeam: IGameCard, ICard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class RocketBooster: IGameCard, ICard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class LaserBlast: IGameCard, ICard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class HoleInSuit : IGameCard, ICard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class Tether : IGameCard, ICard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}