namespace Selfish;

public abstract class Deck<T>
{
    public List<T> Cards { get; } = new();

    protected void Shuffle()
    {
        var random = new Random();

        for (int i = 0; i < Cards.Count; i++)
        {
            var swapIndex = random.Next(0, Cards.Count);

            // ReSharper disable once SwapViaDeconstruction
            var swapCard = Cards[i];
            Cards[i] = Cards[swapIndex];
            Cards[swapIndex] = swapCard;
        }
    }

    public T TakeTopCard()
    {
        if (Cards.Count == 0)
        {
            throw new Exception("Deck is empty");
        }

        var card = Cards[0];
        Cards.RemoveAt(0);
        Console.WriteLine("You have picked up a " + card!.GetType().Name);
        return card;
    }

    public void ReplenishIfEmpty(List<ICard> discardPile)
    {
        if (Cards.Count != 0) return;
        
        discardPile.Clear();
        BuildDeck();
    }

    protected abstract void BuildDeck();
}