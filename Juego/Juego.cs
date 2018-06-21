using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Juego : Form
    {
        List<Player> players = new List<Player>();
        Map mapa;

        public Juego(List<Player> players)
        {
            InitializeComponent();
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }
    }
}
