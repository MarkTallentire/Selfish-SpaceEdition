namespace Selfish;

public class AstronautCard(AstronautColour astronautColour) : ICard
{
    public CardType CardType { get; } = CardType.Astronaut;
    public AstronautColour AstronautColour { get; } = astronautColour;
}