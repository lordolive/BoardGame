using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BoardGame
{
    public abstract class Board
    {
        protected Tile[,] _boardStorage;
        protected Vector3[] _directions;
        protected Coordinate _origin = new Coordinate();

        public Board(int x, int y, Coordinate origin = null)
        {
            _boardStorage = new Tile[x, y];

            if(origin != null)
            {
                _origin = origin;
            }
        }

        virtual public Tile GetTile(Coordinate coord)
        {
            var storageAccessor = coord + _origin;
            if(storageAccessor.X < 0 || storageAccessor.X >= _boardStorage.GetLength(0)
                || storageAccessor.Y < 0 || storageAccessor.Y >= _boardStorage.GetLength(1))
            {
                return null;
            }
            return _boardStorage[(int)coord.X, (int) coord.Y];
        }

        virtual public Tile GetTile(int x, int y)
        {
            var storageX = x + _origin.X;
            var storageY = y + _origin.Y;
            if (storageX< 0 || storageX >= _boardStorage.GetLength(0)
                || storageY < 0 || storageY >= _boardStorage.GetLength(1))
            {
                return null;
            }
            return _boardStorage[(int)storageX, (int)storageY];
        }

        public List<Tile> GetNeighbors(Coordinate coord)
        {
            var result = new List<Tile>();
            foreach(var direction in _directions)
            {
                var nextTile = GetTile(coord + direction);
                if(nextTile != null)
                {
                    result.Add(nextTile);
                }
            }
            return result;
        }

        public void SetAllNeighbors()
        {
            foreach(var tile in _boardStorage)
            {
                tile.Neighbors = GetNeighbors(tile.Position);
            }
        }
    }
}
