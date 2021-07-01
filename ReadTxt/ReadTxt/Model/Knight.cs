using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    class Knight : ChessPiece
    {
        public const int minMoveValue = 1;
        public const int maxMoveValue = 2;
        public Knight(string name, bool isdestroyed, int point) : base(name, isdestroyed, point)
        {

        }

        public override List<Index> calculate(Index index)
        {
            List<Index> moveList = new List<Index>();

            // Knight moves... &&  1- index.x +2 index.y -1 && 2- index.x +2 index.y +1 &&  3- index.x -2 index.y -1 &&  4- index.x -2 index.y +1//,wwwwwssssssssssssssssssssssssssssssssssssssssssssssss
            int xAxis, yAxis, counter = 0;
            for (int i = 0; i < 4; i++) // we have 8 possibilities for knight. But we will describe them in 4 loop
            {
                xAxis = index.x; yAxis = index.y; counter = 0;
                switch (i) // all posibilities one by one...
                {
                    case 0: // x axis +2 and y axis 1 square ---- x axis +1 and y axis +2 square move...
                        do
                        {
                            xAxis += minMoveValue; yAxis += maxMoveValue;
                            if (xAxis < Index.maxBoardValue && yAxis < Index.maxBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            xAxis = index.x; yAxis = index.y;
                            xAxis += maxMoveValue; yAxis += minMoveValue;
                            if (xAxis < Index.maxBoardValue && yAxis < Index.maxBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            counter++;
                        }
                        while (xAxis > Index.minBoardValue && yAxis > Index.minBoardValue && counter % 2 == 0); // in the first case x and y are reduced until they are greater than zero
                        break;
                    case 1:
                        do
                        {
                            xAxis += minMoveValue; yAxis -= maxMoveValue;
                            if (xAxis < Index.maxBoardValue && yAxis > Index.minBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            xAxis = index.x; yAxis = index.y;
                            xAxis += maxMoveValue; yAxis -= minMoveValue;
                            if (xAxis < Index.maxBoardValue && yAxis > Index.minBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            counter++;
                        }
                        while (xAxis > Index.minBoardValue && yAxis > Index.minBoardValue && counter % 2 == 0); // in the first case x and y are reduced until they are greater than zero
                        break;
                    case 2:
                        do
                        {
                            xAxis -= minMoveValue; yAxis -= maxMoveValue;
                            if (xAxis > Index.minBoardValue && yAxis > Index.minBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            xAxis = index.x; yAxis = index.y;
                            xAxis -= maxMoveValue; yAxis -= minMoveValue;
                            if (xAxis > Index.maxBoardValue && yAxis > Index.minBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            counter++;
                        }
                        while (xAxis > Index.minBoardValue && yAxis > Index.minBoardValue && counter % 2 == 0); // in the first case x and y are reduced until they are greater than zero
                        break;
                    case 3:
                        do
                        {
                            xAxis -= minMoveValue; yAxis += maxMoveValue;
                            if (xAxis > Index.maxBoardValue && yAxis < Index.minBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            xAxis = index.x; yAxis = index.y;
                            xAxis -= maxMoveValue; yAxis += minMoveValue;
                            if (xAxis > Index.maxBoardValue && yAxis < Index.minBoardValue) moveList.Add(new Index(xAxis, yAxis));// board limitations  8x8=64 squares...
                            counter++;
                        }
                        while (xAxis > Index.minBoardValue && yAxis > Index.minBoardValue && counter % 2 == 0); // in the first case x and y are reduced until they are greater than zero
                        break;
                    default:
                        break;
                }
            }
            return moveList;
        }
    }
}
