using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Juego
{
    public enum MapType { Untyped};

    public class Map
    {
        MapType type;
        string name;
        int width, length;

        Block[,] cells;

        public Block[,] Cells { get => cells; set => cells = value; }
        public int Width { get => width; }
        public int Length { get => length; }
        public string Name { get => name; set => name = value; }
        public MapType Type { get => type; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">nombre del mapa</param>
        /// <param name="width">Ancho del mapa en cuadraditos</param>
        /// <param name="length">largo del mapa en cuadraditos</param>
        public Map(string name, int width, int length)
        {
            type = MapType.Untyped;

            this.name = name;
            this.width = width;
            this.length = length;

            cells = new Block[width, length];

        }

        public Map(string name, int width, int length, MapType type)
        {
            this.type = type;

            this.name = name;
            this.width = width;
            this.length = length;

            cells = new Block[width, length];

        }

        public static Map Load(string Name)
        {
            Map m = new Map();

            return m;
        }
    }
}
