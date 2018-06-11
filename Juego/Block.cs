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
        Image image;
        bool walkeable;
        bool occupied;

        public Image Image { get => image; set => image = value; }
        public bool Walkeable { get => walkeable; set => walkeable = value; }
        public bool Occupied { get => occupied; set => occupied = value; }

        public Block(Image image)
        {
            this.image = new Bitmap(image);
        }
    }
}
