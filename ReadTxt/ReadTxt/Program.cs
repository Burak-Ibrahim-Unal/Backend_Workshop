using ReadTxt.Helper;
using ReadTxt.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Algorithm that halves the score of chess pieces that only bishops and knights can destroy from txt
            empty area (0 point), p = pawn (1 point) , k= rook (5 points), f = bishop(3 points),a= knight (3 points), v = Queen (9 point),s = king (100 points)
            black chess pieces = s , white chess pieces = a,
            and from txt examples: xx = empty area, black rook = ks (k=rook,s=black chess piece) , white king = sa (s = king, a = white chess piece)
            pawn = 1 point, rook= 5 points,knight = 3 points,bishop= 3 points, queen= 9 points,king = 100 points
            If a chess piece is capable of destroying the opposing piece, that piece's score is halved
            For example black pawn location is B3 and this pawn can destroy A2 and C2 locations. And chess pieces points are decrased by %50 at A2 and C2 locations.


            */
            
            ChessTable ct = new ChessTable();
            ct.calculate();
            ct.score();
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "\\fileName.txt");
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Console.WriteLine(string.Concat(Directory.GetCurrentDirectory(), "\\board1.txt"));
            Console.ReadKey();
        }
    }
}


// busine