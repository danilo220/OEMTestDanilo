using OEMTestDanilo.Interfaces;
using OEMTestDanilo.Models.Enums;

namespace OEMTestDanilo.Models
{
    public class Player : IRPS, IPoints
    {
        public Player() 
        { 

        }
        public Player(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Points { get; set; }
        public MovePlayed Move
        {
            get
            {
                return move;
            }
        }
        private MovePlayed move;
        public void GetMove()
        {
            Console.WriteLine("Play: rock, paper or scissors:  ");
            string moveTyped = Console.ReadLine().ToLower();
            if(moveTyped == "rock")
            {
                move = MovePlayed.Rock;
            }
            else if (moveTyped == "paper") 
            {
                move = MovePlayed.Paper;
            }
            else if (moveTyped == "scissors")
            {
                move = MovePlayed.Scissors;
            }
        }
    }
}
