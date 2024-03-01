namespace Selfish;

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