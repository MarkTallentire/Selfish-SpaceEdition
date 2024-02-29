using Selfish;

var cardFactory = new AstronautCardFactory();
var astronautCards = cardFactory.Build();

var computer = new Computer();
computer.ChooseAstronautCard(astronautCards);

var player = new Player();
player.ChooseAstronautCard(astronautCards);


var deck = new Deck();

deck.Deal([computer, player]);


var gameBoard = new Board([computer, player], deck);

gameBoard.Generate();
gameBoard.Render();