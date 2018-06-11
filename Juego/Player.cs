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

        public List<Character> Characters { get => characters; set => characters = value; }
        public string Name { get => name; set => name = value; }

        public Player(string name)
        {
            this.name = name;
        }
    }
}
