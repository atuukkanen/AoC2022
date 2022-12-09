namespace D9.Model
{
    public struct Position
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public Position Sum(PositionDifference p)
        {
            return new Position {
                Horizontal = this.Horizontal + p.Horizontal,
                Vertical = this.Vertical + p.Vertical,
            };
        }

        public override bool Equals(obj? other)
        {
            if (other is Position p)
            {
                return p.Horizontal == this.Horizontal && p.Vertical == this.Vertical;
            }
            return false;
        }
    }
}