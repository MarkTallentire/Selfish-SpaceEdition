namespace Selfish;

public interface ISpaceCard : ICard
{
    public void DoAction();
}

public class BlankSpace : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class UsefulJunk : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class MysteriousNebula : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class HyperSpace : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class Meteoroid : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class CosmicRadiation : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class AsteroidField : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class GravitationalAnomaly : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class WormHole : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}

public class SolarFlare : ISpaceCard
{
    public CardType CardType { get; } = CardType.Space;

    public void DoAction()
    {
        throw new NotImplementedException();
    }
}