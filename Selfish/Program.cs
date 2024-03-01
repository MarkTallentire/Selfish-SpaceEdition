using Selfish;

var cardFactory = new AstronautCardFactory();
var astronautCards = cardFactory.Build();

Console.WriteLine("Welcome to Selfish!");
Console.WriteLine("Please choose the number of Human Players");
int? humanPlayers = null;
while (humanPlayers == null)
{
    var input = Convert.ToInt32(Console.ReadLine());
    
    if(input > 5 || input < 1)
    {
        Console.WriteLine("Please enter a number between 1 and 5");
    }
    else
    {
        humanPlayers = input;
    }
}

int? computerPlayers = null;
if (humanPlayers < 5)
{
    Console.WriteLine("Please choose the number of Computer Players");
    while (computerPlayers == null)
    {
        var input = Convert.ToInt32(Console.ReadLine());
    
        if (input < 1 || input > Math.Min(5, 5 - (int)humanPlayers))
        {
            Console.WriteLine("Please enter a number between 1 and " + Math.Min(5, 5 - (int)humanPlayers));
        }
        else
        {
            computerPlayers = input;
        }
    }
}

var players = new List<IPlayer>();
for (int i = 0; i < humanPlayers; i++)
{
    var player = new Player();
    player.ChooseAstronautCard(astronautCards);
    players.Add(player);
}
for (int i = 0; i < computerPlayers; i++)
{
    var computer = new Computer();
    computer.ChooseAstronautCard(astronautCards);
    players.Add(computer);
}

var deck = new GameDeck();
deck.Deal(players);

var spaceDeck = new SpaceDeck();
var gameBoard = new Board(players, deck, spaceDeck);

gameBoard.Generate();

var game = new Game(deck, spaceDeck, gameBoard, players);