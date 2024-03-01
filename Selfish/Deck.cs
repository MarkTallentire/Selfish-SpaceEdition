namespace Selfish;

public class Deck
{
    private const int NumberOfSingleOxygenCards = 38;
    private const int NumberOfDoubleOxygenCards = 10;
    private const int NumberOfGameCards = 4;

    private const int NumberOfSingleOxygenPerPlayer = 4;
    //private const int NumberOfDoubleOxygenPerPlayer = 1; //Using first or default so cant do this one. be aware this will need to be a list in the future.
    private const int NumberOfRandomGameCardsPerPlayer = 4;
    
    public List<IGameCard> Cards { get; } = new();

    public Deck()
    {
        //Create all the cards and add them to the deck
        AddOxygenCards();
        AddGameCards();
    }

    public void Deal(List<IPlayer> players)
    {
        foreach (var player in players)
        {
            var doubleOxygenCard = Cards
                .FirstOrDefault(x => x.CardType == CardType.DoubleOxygen);
            
            var singleOxygenCards = Cards
                .Where(x => x.CardType == CardType.SingleOxygen)
                .Take(NumberOfSingleOxygenPerPlayer)
                .ToList();
            
            player.AddCardToHand(doubleOxygenCard!);
            Cards.Remove(doubleOxygenCard!);
            
            foreach (var singleOxygenCard in singleOxygenCards)
            {
                player.AddCardToHand(singleOxygenCard!);
                Cards.Remove(singleOxygenCard!);
            }
            
            Shuffle();

            for (int i = 0; i < NumberOfRandomGameCardsPerPlayer; i++)
            {
                player.AddCardToHand(Cards[i]);
            }
        }
    }

    private void Shuffle()
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
    
    private void AddOxygenCards()
    {
        for (var i = 0; i < NumberOfSingleOxygenCards; i++ )
        {
            Cards.Add(new SingleOxygenCard());
        }

        for (var i = 0; i < NumberOfDoubleOxygenCards; i++)
        {
            Cards.Add(new DoubleOxygenCard());
        }
        
    }

    private void AddGameCards()
    {
        for (int i = 0; i < NumberOfGameCards; i++)
        {
            Cards.Add(new Shield());
            Cards.Add(new Tether());
            Cards.Add(new LaserBlast());
            Cards.Add(new RocketBooster());
            Cards.Add(new HoleInSuit());
            Cards.Add(new TractorBeam());

            //These 2 cards only have 3 of each.
            if (i != NumberOfGameCards - 1) continue;
            
            Cards.Add(new HackSuit());
            Cards.Add(new OxygenSiphon());

        }
    }
}