using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Coordinate
    {
        public float X { get => _x; }
        public float Y { get => _y; }
        public float Z { get => _z; }

        private float _x;
        private float _y;
        private float _z;

        public Coordinate(float x =0, float y=0, float z = 0)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Coordinate operator +(Coordinate coord, System.Numerics.Vector3 vect)
        {
            var newX = coord.X + vect.X;
            var newY = coord.Y + vect.Y;
            var newZ = coord.Z + vect.Z;
            return new Coordinate(newX, newY, newZ);
        }

        public static Coordinate operator -(Coordinate coord, System.Numerics.Vector3 vect)
        {
            var newX = coord.X - vect.X;
            var newY = coord.Y - vect.Y;
            var newZ = coord.Z - vect.Z;
            return new Coordinate(newX, newY, newZ);
        }

        public static Coordinate operator +(Coordinate coord1, Coordinate coord2)
        {
            var newX = coord1.X + coord2.X;
            var newY = coord1.Y + coord2.Y;
            var newZ = coord1.Z + coord2.Z;
            return new Coordinate(newX, newY, newZ);
        }

        public static Coordinate operator -(Coordinate coord1, Coordinate coord2)
        {
            var newX = coord1.X - coord2.X;
            var newY = coord1.Y - coord2.Y;
            var newZ = coord1.Z - coord2.Z;
            return new Coordinate(newX, newY, newZ);
        }
    }
}
