using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    static class ModelFactory
    {
        // We will create objects based on the names in the text document at TxOku Class
        public static ChessPiece CreateModel(string name)
        {
            if (name == "ks" || name == "kb")
            {
                return new Rook(name, false, 5);
            }
            else if (name == "as" || name == "ab")
            {

                return new Knight(name, false, 3);
            }
            else if (name == "fs" || name == "fb")
            {

                return new Bishop(name, false, 3);
            }
            else if (name == "vs" || name == "vb")
            {

                return new Queen(name, false, 9);
            }
            else if (name == "ss" || name == "sb")
            {

                return new King(name, false, 100);
            }
            else if (name == "ps" || name == "pb")
            {

                return new Pawn(name, false, 1);
            }
            else
            {
                return new Empty("xx", false, 0);
            }
        }
    }
}
