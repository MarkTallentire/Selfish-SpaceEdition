namespace Selfish;

public class Computer : IPlayer
{
    public AstronautCard AstronautCard { get; private set; } = default!;
    public List<IGameCard> Hand { get; } = [];
    public bool IsDead { get; private set; }

    public void ChooseAstronautCard(List<AstronautCard> availableCards)
    {
        var random = new Random();
        AstronautCard = availableCards[random.Next(0, availableCards.Count)];
        availableCards.Remove(AstronautCard);
    }

    public void AddCardToHand(IGameCard card)
    {
        Hand.Add(card);
    }

    public void Kill()
    {
        IsDead = true;
    }
}