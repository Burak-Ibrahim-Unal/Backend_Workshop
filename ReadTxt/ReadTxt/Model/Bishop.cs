using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    class Bishop : ChessPiece
    {
        public Bishop(string name, bool isdestroyed, int point) : base(name, isdestroyed, point)
        {

        }


        public override List<Index> calculate(Index index)
        {
            List<Index> moveList = new List<Index>();

            // Bishops moves... &&  1- index.x-- index.y-- && 2- index.x++ index.y++ &&  3- index.x-- index.y++ &&  4- index.x++ index.y--
            //int xAxis = index.x; int yAxis = index.y;
            int xAxis, yAxis;
            for (int i = 0; i < 4; i++) // we have 4 possibilities for bishop. 
            {
                xAxis = index.x; yAxis = index.y;
                switch (i) // all posibilities one by one...
                {
                    //All move posibilities for bishop...
                    case 0:
                        while (xAxis > Index.minBoardValue && yAxis > Index.minBoardValue) // in the first case x and y are reduced until they are greater than zero
                        {
                            xAxis--; yAxis--;
                            moveList.Add(new Index(xAxis, yAxis));
                        }
                        break;
                    case 1:
                        while (xAxis < Index.maxBoardValue && yAxis < Index.maxBoardValue) // in the second case x and y are incremented until they are less than eight
                        {
                            xAxis++; yAxis++;
                            moveList.Add(new Index(xAxis, yAxis));
                        }
                        break;
                    case 2:
                        while (xAxis < Index.maxBoardValue && yAxis > Index.minBoardValue) // in the third case x is incremented until it is less than eight and y is reduced until it is greater than zero
                        {
                            xAxis++; yAxis--;
                            moveList.Add(new Index(xAxis, yAxis));
                        }
                        break;
                    case 3:
                        while (xAxis > Index.minBoardValue && yAxis < Index.maxBoardValue) // in the second case x is reduced until it is greater than zero and y is incremented until it is less than eight
                        {
                            xAxis--; yAxis++;
                            moveList.Add(new Index(xAxis, yAxis));
                        }
                        break;
                    default:
                        break;
                }
            }
            return moveList;
        }
    }
}
