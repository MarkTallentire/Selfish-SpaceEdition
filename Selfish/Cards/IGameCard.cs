namespace Selfish;

public interface IGameCard : ICard
{
    public void Use();
}

class SingleOxygenCard : IGameCard
{
    public CardType CardType { get; } = CardType.SingleOxygen;
    
    public void Use()
    {
        throw new NotImplementedException();
    }
}

class DoubleOxygenCard : IGameCard
{
    public CardType CardType { get; } = CardType.DoubleOxygen;
    
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