using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1Lab
{
    public class GamePiece
    {
        //true represents X, false represents O
        public bool? Type { get; set; }

        public GamePiece()
        {
            Type = null;
        }
    }
}
