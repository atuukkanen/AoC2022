using D9.Model;
using D9.Command;

namespace D9
{
    public class Main
    {
        public int Solve()
        {
            var lines = File.ReadLines("input.txt");
            
            var startPosition = Position {
                Vertical = 0,
                Horizontal = 0,
            };
            var head = new Head(startPosition);

            var knotCount = 10;
            var tails = new List<Tail>();
            for (int i = 0; i < tailCount; ++i) {
                Knot previous = i == 0 ? head : tails[i - 1];
                tails.Add(new Tail(startPosition, previous));
            }

            var handler = new CommandHandler(head, tails);
            foreach (var line in lines)
            {
                var command = MoveCommand.FromCommandLine(line);
                handler.Execute(command);
            }
            var uniqueVisitedPositions = handler.Positions.Distinct();
            return uniqueVisitedPositions.Count();
        }
    }
}