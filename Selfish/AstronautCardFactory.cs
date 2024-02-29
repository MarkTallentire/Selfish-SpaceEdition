namespace Selfish;

public class AstronautCardFactory
{
    public List<AstronautCard> Build()
    {
        return
        [
            new(AstronautColour.Blue),
            new(AstronautColour.Green),
            new(AstronautColour.Purple),
            new(AstronautColour.Red),
            new(AstronautColour.Yellow)
        ];
    }
}