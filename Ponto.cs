using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Trelisa
{
    internal class Ponto
    {
        public int valorX, valorY;
        public List<Barra> barrasPonto = new List<Barra>();

        public Ponto(int x, int y)
        {
            valorX = x;
            valorY = y;
        }

        /* ---- Cria uma barra horizontal e vertical em cada ponto.

            Barra barra1 = new Barra(x - 500, y, x + 500, y,0);
            Barra barra2 = new Barra(x, y - 500, x, y + 500 , 0);
            barrasPonto.Add(barra1);
            barrasPonto.Add(barra2);
            */
    }
}
