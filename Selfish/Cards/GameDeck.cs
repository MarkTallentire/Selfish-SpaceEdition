using Selfish;

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

public class SpaceDeck : Deck<ISpaceCard>
{
    private const int NumberOfUsefulJunkCards = 5;
    private const int NumberOfMysteriousNebulaCards = 2;
    private const int NumberOfHyperSpaceCards = 1;
    private const int NumberOfMeteoroidCards = 4;
    private const int NumberOfCosmicRadiationCards = 6;
    private const int NumberOfBlankSpaceCards = 10;
    private const int NumberOfAsteroidFieldCards = 2;
    private const int NumberOfGravitationalAnomalyCards = 3;
    private const int NumberOfWormHoleCards = 4;
    private const int NumberOfSolarFlareCards = 5;

    public SpaceDeck()
    {
        BuildDeck();
        Shuffle();
    }

    protected override void BuildDeck()
    {
        AddUsefulJunkCards();
        AddMysteriousNebulaCards();
        AddHyperSpaceCards();
        AddMeteoroidCards();
        AddCosmicRadiationCards();
        AddBlankSpaceCards();
        AddAsteroidFieldCards();
        AddGravitationalAnomalyCards();
        AddWormHoleCards();
        AddSolarFlareCards();
    }


    private void AddSolarFlareCards()
    {
        for (int i = 0; i < NumberOfSolarFlareCards; i++)
        {
            Cards.Add(new SolarFlare());
        }
    }

    private void AddWormHoleCards()
    {
        for (int i = 0; i < NumberOfWormHoleCards; i++)
        {
            Cards.Add(new WormHole());
        }
    }

    private void AddGravitationalAnomalyCards()
    {
        for (int i = 0; i < NumberOfGravitationalAnomalyCards; i++)
        {
            Cards.Add(new GravitationalAnomaly());
        }
    }

    private void AddAsteroidFieldCards()
    {
        for (int i = 0; i < NumberOfAsteroidFieldCards; i++)
        {
            Cards.Add(new AsteroidField());
        }
    }

    private void AddBlankSpaceCards()
    {
        for (int i = 0; i < NumberOfBlankSpaceCards; i++)
        {
            Cards.Add(new BlankSpace());
        }
    }

    private void AddCosmicRadiationCards()
    {
        for (int i = 0; i < NumberOfCosmicRadiationCards; i++)
        {
            Cards.Add(new CosmicRadiation());
        }
    }

    private void AddMeteoroidCards()
    {
        for (int i = 0; i < NumberOfMeteoroidCards; i++)
        {
            Cards.Add(new Meteoroid());
        }
    }

    private void AddHyperSpaceCards()
    {
        for (int i = 0; i < NumberOfHyperSpaceCards; i++)
        {
            Cards.Add(new HyperSpace());
        }
    }

    private void AddMysteriousNebulaCards()
    {
        for (int i = 0; i < NumberOfMysteriousNebulaCards; i++)
        {
            Cards.Add(new MysteriousNebula());
        }
    }

    private void AddUsefulJunkCards()
    {
        for (int i = 0; i < NumberOfUsefulJunkCards; i++)
        {
            Cards.Add(new UsefulJunk());
        }
    }

}

public class GameDeck : Deck<IGameCard>, IDealable
{
    private const int NumberOfSingleOxygenCards = 38;
    private const int NumberOfDoubleOxygenCards = 10;
    private const int NumberOfGameCards = 4;

    private const int NumberOfSingleOxygenPerPlayer = 4;

    //private const int NumberOfDoubleOxygenPerPlayer = 1; //Using first or default so cant do this one. be aware this will need to be a list in the future.
    private const int NumberOfRandomGameCardsPerPlayer = 4;

    public GameDeck()
    {
        //Create all the cards and add them to the deck
        BuildDeck();
    }

    protected override void BuildDeck()
    {
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

    private void AddOxygenCards()
    {
        for (var i = 0; i < NumberOfSingleOxygenCards; i++)
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

public interface IDealable
{
    void Deal(List<IPlayer> players);
}