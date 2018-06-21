using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Juego
{
    public class Block
    {
        string terrain, surface, obejct_;
        bool walkeable;
        bool occupied;

        public bool Walkeable { get => walkeable; set => walkeable = value; }
        public bool Occupied { get => occupied; set => occupied = value; }
        public string Terrain { get => terrain; set => terrain = value; }
        public string Surface { get => surface; set => surface = value; }
        public string Obejct { get => obejct_; set => obejct_ = value; }

        public Block()
        {
            occupied = false;
        }
    }
}
