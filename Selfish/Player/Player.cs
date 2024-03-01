namespace Selfish;

public class Player : IPlayer
{
    public AstronautCard AstronautCard { get; private set; } = default!;
    public List<IGameCard> Hand { get; } = [];
    public bool IsDead { get; private set; }


    public void ChooseAstronautCard(List<AstronautCard> availableCards)
    {
        AstronautCard = availableCards[0];
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