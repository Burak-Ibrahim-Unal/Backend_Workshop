using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    class Index
    {
        public int x { get; set; } // chess pieces locations x and y ...
        public int y { get; set; }
        public  const int minBoardValue = 1; // Board limits...
        public  const int maxBoardValue = 8; // Board limits...

        public Index(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
