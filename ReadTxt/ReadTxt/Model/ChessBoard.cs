using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    class ChessBoard
    {
        // It Is ChessBoard class that we define chess board's x,y axies and chess pieces like bishop,king,rook...
        public Index index;
        private ChessPiece chessPiece;


        public ChessBoard(int x, int y, ChessPiece chessPiece) // 3 parameter constructor...
        {
            index = new Index(x, y);
            this.ChessPiece = chessPiece;
        }

        public List<Index> calculate()
        {
            return chessPiece.calculate(index);
        }

        //Encapsulation getter and setter methods.
        internal ChessPiece ChessPiece
        {
            get
            {
                return chessPiece;
            }

            set
            {
                chessPiece = value;
            }
        }
    }
}
