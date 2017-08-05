using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class HexBoard : Board
    {
        public HexBoard(int x, int y, Coordinate origin = null) : base(x, y, origin)
        {
            _directions = new Vector3[] {new Vector3(+1, -1, 0), new Vector3(+1, 0, -1), new Vector3(0, +1, -1),
                    new Vector3(-1, +1, 0), new Vector3(-1, 0, +1), new Vector3(0, -1, +1)};

            for (int i = 0; i < _boardStorage.GetLength(0); i++)
            {
                for (int j = 0; j < _boardStorage.GetLength(1); j++)
                {
                    var k = -i - j;
                    _boardStorage[i, j] = new Tile(new Coordinate(i, j, k));
                }
            }

            SetAllNeighbors();
        }

        public int GetCartesianDistance(Tile source, Tile dest)
        {
            var result = Math.Max(dest.Position.X - source.Position.X, dest.Position.Y - source.Position.Y);
            result = Math.Max(result, dest.Position.Z - source.Position.Z);
            return (int)result;
        }
    }
}
