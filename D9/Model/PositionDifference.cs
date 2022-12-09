namespace D9.Model
{
    public struct PositionDifference
    {
        public int Vertical { get; set; }
        public int Horizontal { get; set; }

        public static PositionDifference Between(Position a, Position b)
        {
            return new PositionDifference
            {
                Vertical = a.Vertical - b.Vertical,
                Horizontal = a.Horizontal - b.Horizontal,
            };
        }
    }
}