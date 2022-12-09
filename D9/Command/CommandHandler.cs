using D9.Model;

namespace D9.Command
{
    public class CommandHandler
    {
        private Head _head;
        private List<Tail> _tails;
        public List<Position> Positions { get; private set; }

        public CommandHandler(Head head, List<Tail> tails)
        {
            _head = head;
            _tails = tails;
            Positions = new List<Position>();
        }

        public void Execute(MoveCommand c)
        {
            for (int i = 0; i < c.Times; ++i)
            {
                _head.Move(c.Direction);
                
                foreach (var tail in tails)
                {
                    if (!tail.HasToMove())
                    {
                        break;
                    }
                    var pd = tail.Difference();
                    PositionDifference toMove = PositionDifference
                    {
                        Horizontal = Math.Sign(pd.Horizontal),
                        Vertical = Math.Sign(pd.Vertical),
                    };
                    tail.Move(toMove);

                    if (tail == tails.Last())
                    {
                        Positions.Add(tail.CurrentPosition);
                    }
                }
            }
        }
    }
}
