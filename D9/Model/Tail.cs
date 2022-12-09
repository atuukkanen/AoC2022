namespace D9.Model
{
    public class Tail : Knot
    {
        private Knot _toFollow;

        public Head(Position startPosition, Knot toFollow) : base(startPosition) {
            _toFollow = toFollow;
        }

        public bool HasToMove()
        {
            var difference = Difference();
            return Math.Abs(difference.Horizontal) > 1 || Math.Abs(difference.Vertical) > 1;
        }

        public PositionDifference Difference()
        {
            return PositionDifferece.Between(_toFollow.CurrentPosition, CurrentPosition);
        }
    }
}
