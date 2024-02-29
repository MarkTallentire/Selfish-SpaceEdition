namespace Selfish;

public class Player : IPlayer
{
    public AstronautCard AstronautCard { get; private set; } = default!;
    public List<IGameCard> Hand { get; } = [];

    public void ChooseAstronautCard(List<AstronautCard> availableCards)
    {
        AstronautCard = availableCards[0];
    }

    public void AddCardToHand(IGameCard card)
    {
        Hand.Add(card);
    }
}