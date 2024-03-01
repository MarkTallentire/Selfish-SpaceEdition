using Selfish;

var cardFactory = new AstronautCardFactory();
var astronautCards = cardFactory.Build();

var computer = new Computer();
computer.ChooseAstronautCard(astronautCards);

var player = new Player();
player.ChooseAstronautCard(astronautCards);

var deck = new GameDeck();
deck.Deal([computer, player]);

var spaceDeck = new SpaceDeck();
var gameBoard = new Board([computer, player], deck, spaceDeck);

gameBoard.Generate();

var game = new Game(deck, spaceDeck, gameBoard, [computer, player]);