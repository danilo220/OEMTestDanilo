using OEMTestDanilo.Interfaces;
using OEMTestDanilo.Models.Enums;

namespace OEMTestDanilo.Models
{
    public class Computer : IRPS, IPoints
    {
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
            Random random = new Random();
            int randomMove = random.Next(1, 4);
            if (randomMove == 1)
            {
                move = MovePlayed.Rock;
            }
            else if (randomMove == 2)
            {
                move = MovePlayed.Paper;
            }
            else
            {
                move = MovePlayed.Scissors;
            }
        }
    }
}
