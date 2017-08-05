using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new SquaredBoard(12, 12);
            var tile = board.GetTile(new Coordinate(3, 3));
            tile.DisplayValue = 'P';
            var tile2 = board.GetTile(new Coordinate(4, 6));
            tile2.DisplayValue = 'T';
            foreach(var neighbor in tile.Neighbors)
            {
                neighbor.DisplayValue = '1';
            }
            foreach(var nexttile in board.GetTile(10, 11).Neighbors)
            {
                nexttile.DisplayValue = '2';
            }
            board.PrintBoard();



            Console.ReadLine();
        }
    }
}
