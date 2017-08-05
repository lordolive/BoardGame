using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Tile
    {
        public Coordinate Position { get => _position; }
        public bool IsLineOfSight { get => _isLineOfSight; }
        public bool IsAccessible { get => _isAccessible; }
        public int MovementCost { get => _movementCost; }
        public char DisplayValue { get => _displayValue; set => _displayValue = value; }
        public List<Tile> Neighbors { get => _neighbors; set => _neighbors = value; }

        private Coordinate _position = null;
        private bool _isLineOfSight = true;
        private bool _isAccessible = true;
        private int _movementCost = 1;
        private char _displayValue;
        private List<Tile> _neighbors = new List<Tile>();

        public Tile(Coordinate coord, char display = ' ')
        {
            _position = coord;
            _displayValue = display;
        }
    }
}
