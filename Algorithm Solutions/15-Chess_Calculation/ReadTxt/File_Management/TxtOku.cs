using ReadTxt.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.File_Management
{
    class TxtOku
    {

        public List<ChessBoard> FindLocations()
        {
            string path = string.Concat(Directory.GetCurrentDirectory(), "\\board2.txt"); // We specify the path to the file we will process.
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //We are creating a file stream object. Parameter 1 indicates the file path, parameter 2 indicates that the file will be opened, and parameter 3 indicates that the file will be accessed for reading data.
            StreamReader sw = new StreamReader(fs);  //We created a StreamReader object for the read operation.
            string text = sw.ReadLine(); // We are reading the txt file line by line.
            int rowCounter = 1; // I expressed each of the lines 1-8 on the board with the variable "say".
            //Dictionary<string, string> readenValuesFromTxt = new Dictionary<string, string>();
            List<ChessBoard> chessBoardElementsList = new List<ChessBoard>();
            // I will add stones like xx - ks to Dictionary with row and column information on each line in txt file.
            // For example, 11 = xx. That means there is xx in the square in row 1 and column 1
            while (text != null) // It should continue reading as long as the txt line read is not empty.
            {
                String[] pieces = text.Split(' '); //   We add the stone in each line into the array by removing the space between them.
                int colCounter = 1; // I have expressed each of the columns 1-8 on the board with the counter variable. The for loop will cause unnecessary performance loss.
                foreach (String piece in pieces) // I add each chess piece and space to my list.
                {
                    ChessPiece chessPiece = ModelFactory.CreateModel(piece); // We create our object based on txt file names.(like xx, kb, ss...)
                    ChessBoard cb = new ChessBoard(rowCounter,colCounter, chessPiece); // We add all elements with X and Y locations,We add their names,is destroyed and points properties from Chesspiece class. 
                    chessBoardElementsList.Add(cb);
                    //readenValuesFromTxt.Add(rowCounter.ToString() + colCounter.ToString(), piece); // say.ToString() = row , sayac2.ToString() = column
                    colCounter++; // I increased it by 1 to move to another column.
                }
                    
                rowCounter++; colCounter++; // We increased it by 1 so that it goes to another row.
                text = sw.ReadLine(); //read next line
            }


            //We performed line-by-line reading and after the last line was read, we finished the reading process,end reading process and closed the txt file.
            sw.Close();
            fs.Close();
            return chessBoardElementsList; // We are returning our list.
        }



    }
}
