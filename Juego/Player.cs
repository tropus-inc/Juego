using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Player
    {
        string name;
        List<Character> characters = new List<Character>();

        public Player(string name)
        {
            this.name = name;
        }

    }
}
