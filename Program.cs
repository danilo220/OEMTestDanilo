// See https://aka.ms/new-console-template for more information

using OEMTestDanilo.Models;

class MainProgram
{
    static void Main(string[] args)
    {
        GameManager gameManager = new GameManager();
        string playerName = gameManager.GetPlayerName();
        Player player = new Player(playerName);
        Computer computer = new Computer();

        gameManager.DisplayWelcomeMessage(player.Name);

        bool isGameOver = false;

        while (!isGameOver)
        {
            player.GetMove();
            computer.GetMove();
            gameManager.GetWinnerOutcome(player.Move, computer.Move);

            Console.WriteLine("Player played: " + player.Move);
            Console.WriteLine("Computer played: " + computer.Move);

            Console.WriteLine("Winner: " + gameManager.Winner);
            int tempPlayerPoints = player.Points;
            int tempComputerPoints = computer.Points;
            gameManager.GivePointToWinner(gameManager.Winner, ref tempPlayerPoints, ref tempComputerPoints);
            player.Points = tempPlayerPoints;
            computer.Points = tempComputerPoints;

            Console.WriteLine(player.Name + " the legend has: " + player.Points + " points");
            Console.WriteLine("The computer has: " + computer.Points + " points");

            isGameOver = gameManager.IsGameOver();
        }
    }
}