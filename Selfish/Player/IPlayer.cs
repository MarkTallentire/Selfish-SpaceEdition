namespace Selfish;

public interface IPlayer
{
    public AstronautCard AstronautCard { get; }
    public List<IGameCard> Hand { get; }
    bool IsDead { get; } 

    public void ChooseAstronautCard(List<AstronautCard> availableCards);

    public void AddCardToHand(IGameCard card);

    public void Kill();
    
}