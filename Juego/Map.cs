using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Juego
{
    public enum MapType { Untyped = 0};

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

        public static Map Load(string name)
        {
            StreamReader lector = new StreamReader(name + ".map");
            Map m;
            int alto, ancho;
            string[] s = new string[4];

            ancho = Convert.ToInt32(lector.ReadLine().Split(':')[1]);
            alto = Convert.ToInt32(lector.ReadLine().Split(':')[1]);

            m = new Map(name, alto, ancho, Convert.ToInt32(lector.ReadLine().Split(':')[1]));

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    s = lector.ReadLine().Split('/');

                    m.Cells[x, y].Terrain = s[0].Split(':')[0];
                    m.Cells[x, y].Surface = s[1];
                    m.Cells[x, y].Obejct = s[2];
                    
                    if(s[3] == "0")
                    {
                        m.Cells[x, y].Walkeable = false;
                    }
                    else if (s[3] == "1")
                    {
                        m.Cells[x, y].Walkeable = true;
                    }
                }
            }

            return m;
        }
    }
}
