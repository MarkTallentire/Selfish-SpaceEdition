namespace Selfish;

public interface IGameCard : ICard
{
    public void Use();
}

class OxygenCard : IGameCard
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


public class OxygenSiphon : IGameCard
{
    public CardType CardType { get; } = CardType.Game;
    
    public void Use()
    {
        throw new NotImplementedException();
    }
}

public class Shield : IGameCard
{
    public CardType CardType { get; } = CardType.Game;
    
    public void Use()
    {
        throw new NotImplementedException();
    }
}

public class HackSuit: IGameCard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}


public class TractorBeam: IGameCard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class RocketBooster: IGameCard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class LaserBlast: IGameCard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class HoleInSuit : IGameCard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}

public class Tether : IGameCard
{
    public void Use()
    {
        throw new NotImplementedException();
    }

    public CardType CardType { get; } = CardType.Game;
}