using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    abstract class ChessPiece // We define it abstract because we usee this class for inheritance.We dont create an object from this class.
    {
        // It Is ChessPiece class that we define chess pieces's name,destroyed or onr and points...
        private string name;
        private bool isDestroyed;
        private float points;
        //public List<ChessPiece> destroy = List<ChessPiece>(); //Test...

        public abstract List<Index> calculate(Index index); // method prototype...We override it at inherited classes.

        public ChessPiece(string name,bool isdestroyed, float point) // constructor with 3 parameter
        {
            this.name = name;
            this.isDestroyed = isdestroyed;
            this.points = point;
        }

        //Encapsulation
        public bool IsDestroyed
        {
            get
            {
                return isDestroyed;
            }

            set
            {
                isDestroyed = value;
            }
        }

        public float Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
