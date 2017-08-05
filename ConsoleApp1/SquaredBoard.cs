using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace BoardGame
{
    class SquaredBoard : Board
    {
        public SquaredBoard(int x, int y, Coordinate origin = null) : base(x, y, origin)
        {
            _directions = new Vector3[] { new Vector3(1, 0, 0), new Vector3(0, 1, 0),
                    new Vector3(-1, 0, 0), new Vector3(0, -1, 0)};

            for(int i = 0; i < _boardStorage.GetLength(0); i++)
            {
                for (int j = 0; j < _boardStorage.GetLength(1); j++)
                {
                    _boardStorage[i, j] = new Tile(new Coordinate(i, j));
                }
            }

            SetAllNeighbors();
        }

        public void PrintBoard()
        {
            string horizontalLine = string.Concat(Enumerable.Repeat("-", _boardStorage.GetLength(0) * 4 + 1));
            for (int i = _boardStorage.GetLength(1) - 1; i >= 0; i--)
            {
                Console.Write("\n " + horizontalLine + "\n | ");
                for (int j = 0; j < _boardStorage.GetLength(0); j++)
                {
                    Console.Write(_boardStorage[j, i].DisplayValue + " | ");
                }
            }
            Console.Write("\n " + horizontalLine);
        }

        public int GetCartesianDistance(Tile source, Tile dest)
        {
            var distX = dest.Position.X - source.Position.X;
            var distY = dest.Position.Y - source.Position.Y;
            return (int)(distX + distY);
        }
    }
}
