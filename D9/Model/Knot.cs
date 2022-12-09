namespace D9.Model
{
    public abstract class Knot
    {
        public Position CurrentPosition { get; private set; }
        
        public Knot(Position startPosition)
        {
            CurrentPosition = startPosition;
        }

        public void Move(Direction d)
        {
            PositionDifference pd;
            switch (d) {
                case (Direction.Up):
                    pd = new PositionDifference
                    {
                        Horizontal = 0,
                        Vertical = 1,
                    };
                    break;
                case (Direction.Down):
                    pd = new PositionDifference
                    {
                        Horizontal = 0,
                        Vertical = -1,
                    };
                    break;
                case (Direction.Right):
                    pd = new PositionDifference
                    {
                        Horizontal = 1,
                        Vertical = 0,
                    };
                    break;
                case (Direction.Left):
                    pd = new PositionDifference
                    {
                        Horizontal = 1,
                        Vertical = 0,
                    };
                    break;
                default:
                    throw new Exception("Vittua saatanan");
            }
            Move(pd);
        }

        public void Move(PositionDifference pd)
        {
            CurrentPosition = CurrentPosition.Sum(pd);
        }
    }
}