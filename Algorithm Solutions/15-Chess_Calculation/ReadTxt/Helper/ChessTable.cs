using ReadTxt.File_Management;
using ReadTxt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Helper
{
    class ChessTable
    {
        List<ChessBoard> ChessBoardElementList;
        public ChessTable()
        {
            TxtOku Locations = new TxtOku(); // We created new TxtOku Object and we will use FindLocations funtion
            ChessBoardElementList = Locations.FindLocations(); // We assigned our dictionary list to new dictionary object.
        }

        public void score()
        {
            float whiteSum = 0; float blackSum = 0;
            foreach (var item in ChessBoardElementList)
            {
                if (item.ChessPiece.Name[1] == 'b') whiteSum += item.ChessPiece.Points; // Black pieces sum process...
                if (item.ChessPiece.Name[1] == 's') blackSum += item.ChessPiece.Points; // White pieces sum process...
            }
            Console.WriteLine("White Piece sum is:{0}", whiteSum); // final outputs
            Console.WriteLine("Black Piece sum is:{0}", blackSum);
        }

        public void calculate() // The methods that calculate points of chess pieces...
        {
            foreach (var chessBoard in ChessBoardElementList) // We find the black bishop locations
            {
                List<Index> indexList;
                if (chessBoard.ChessPiece is Empty) // if chessboard square is xx/empty just continue
                {
                    continue;
                }

                indexList = chessBoard.calculate(); //Overridden method...
                indexList.ForEach((element) =>
                {
                    // square cant be empty,locations must be match and colors cant be same to destroy piece...
                    var piece = from s in ChessBoardElementList
                                where s.index.x == element.x && s.index.y == element.y && !(s.ChessPiece is Empty) && !(s.ChessPiece.Name[1].ToString().Equals(chessBoard.ChessPiece.Name[1].ToString()))
                                select s.ChessPiece;

                    foreach (var item in piece) // section that calculates points
                    {
                        item.IsDestroyed = true;
                        item.Points /= 2.0f;
                    }
                });
            }
        }
    }
}
