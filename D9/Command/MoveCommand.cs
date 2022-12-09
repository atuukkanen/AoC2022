using D9.Model;

namespace D9.Command
{
    public class MoveCommand
    {
        public Direction To { get; private set; }
        public int Times { get; private set; }

        public static MoveCommand FromCommandLine(string line)
        {
            var parts = line.Split(" ");
            if (parts.Count() != 2)
            {
                throw new Exception("Vittua saatanan: " + line);
            }

            var directionAsString = parts[0];
            Direction d;
            if (directionAsString == "R")
            {
                d = Direction.Right;
            }
            else if (directionAsString == "L")
            {
                d = Direction.Left;
            }
            else if (directionAsString == "U")
            {
                d = Direction.Up;
            }
            else if (directionAsString == "D")
            {
                d = Direction.Down;
            }
            else 
            {
                throw new Exception("No helvetti: " + line);
            }

            return new MoveCommand
            {
                To = d,
                Times = Int32.Parse(parts[1]);
            };
        }
    }
}