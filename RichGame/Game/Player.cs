using RichGame.Enumerates;

namespace RichGame.Game
{
    public class Player
    {
        public static readonly int MaxPlayers = 8;
        
        public MoveDirection Direction { get; private set; }
        
        public decimal Cash { get; private set; }
        public decimal Deposit { get; private set; }
        
        public Player(MoveDirection direction, decimal initialCash, decimal initialDeposit)
        {
            Direction = direction;
            
            Cash = initialCash;
            Deposit = initialDeposit;
        }
    }
}