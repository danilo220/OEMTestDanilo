using OEMTestDanilo.Models.Enums;
using System.Numerics;

namespace OEMTestDanilo.Models
{
    public class GameManager
    {
        public string Winner
        {
            get
            {
                 return WinnerOutcome.ToString();
            }
        }
        private WinnerOutcome WinnerOutcome { get; set; }
        public void GetWinnerOutcome(MovePlayed playerMove, MovePlayed computerMove)
        {
            if (playerMove == MovePlayed.Rock && computerMove == MovePlayed.Scissors)
                WinnerOutcome = WinnerOutcome.Player;
            else if (playerMove == MovePlayed.Rock && computerMove == MovePlayed.Paper)
                WinnerOutcome = WinnerOutcome.Computer;
            else if (playerMove == MovePlayed.Paper && computerMove == MovePlayed.Rock)
                WinnerOutcome = WinnerOutcome.Player;
            else if (playerMove == MovePlayed.Paper && computerMove == MovePlayed.Scissors)
                WinnerOutcome = WinnerOutcome.Computer;
            else if (playerMove == MovePlayed.Scissors && computerMove == MovePlayed.Paper)
                WinnerOutcome = WinnerOutcome.Player;
            else if (playerMove == MovePlayed.Paper && computerMove == MovePlayed.Rock)
                WinnerOutcome = WinnerOutcome.Computer;
            else
                WinnerOutcome = WinnerOutcome.Draw;
        }

        public void DisplayWelcomeMessage(string playerName)
        {
            Console.WriteLine("Welcome " + playerName + " to rock paper scissors game! :)");
        }

        public string GetPlayerName()
        {
            Console.WriteLine("Enter your name:  ");
            return Console.ReadLine();
        }

        public void GivePointToWinner(string winner, ref int playerPoints, ref int computerPoints)
        {
            if (winner == WinnerOutcome.Player.ToString())
            {
                playerPoints++;
            }
            else if (winner == WinnerOutcome.Computer.ToString())
            {
                computerPoints++;
            }
        }
        public bool IsGameOver()
        {
            Console.WriteLine("Continue playing? y/n");
            string conTinuePlaying = Console.ReadLine().ToLower();
            return conTinuePlaying != "y";
        }
    }
}
