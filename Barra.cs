using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Trelisa
{
    internal class Barra
    {
        // TRUE = CIMA OU DIREITA
        // FALSE = BAIXO OU ESQUERDA
        public int pontoInicialX, pontoInicialY, pontoFinalX, pontoFinalY, forca;
        public bool estainclinada = true, sentidoVertical = true, sentidoHorizontal = false;
        public double angle, distancia;
        //public Ponto pontoIntersecção;

        public Barra(int pontoX, int pontoY, int pontoFX, int pontoFY, int forc)
        {
            pontoInicialX = pontoX;
            pontoInicialY = pontoY;
            pontoFinalX = pontoFX;
            pontoFinalY = pontoFY;
            forca = forc;

            if (pontoFinalX - pontoInicialX > 0)
            {
                sentidoHorizontal = true;
            }
            if (pontoFinalY - pontoInicialY > 0)
            {
                sentidoVertical = false;

            }
            if (pontoFinalX - pontoInicialX == 0 | pontoFinalY - pontoInicialY == 0)
            {
                estainclinada = false;
            }

            if (sentidoHorizontal == true && sentidoVertical == true)
            {
                angle = (Math.Atan2(pontoFinalY - pontoInicialY, pontoFinalX - pontoInicialX) * (180 / Math.PI)) * -1;
            }
            else if(sentidoHorizontal == false && sentidoVertical == false)
            {
                angle = 180 - (Math.Atan2(pontoFinalY - pontoInicialY, pontoFinalX - pontoInicialX) * (180 / Math.PI));
            }
            else if(sentidoHorizontal == true && sentidoVertical == false)
            {
                angle = Math.Atan2(pontoFinalY - pontoInicialY, pontoFinalX - pontoInicialX) * (180 / Math.PI);
            }
            else if(sentidoHorizontal == false && sentidoVertical == true)
            {
                angle = 180 - ((Math.Atan2(pontoFinalY - pontoInicialY, pontoFinalX - pontoInicialX) * (180 / Math.PI) * -1));
            }

            distancia = Math.Sqrt(Math.Pow(pontoInicialX- pontoFinalX, 2) + Math.Pow(pontoInicialY - pontoFinalY, 2));


        }

        /*
            Não precisa disso - Encontra ponto de intersecção
           if (estainclinada == true)
           {
               // Line AB represented as a1x + b1y = c1 
               int a1 = pontoY - pontoY;
               int b1 = (pontoX - 500) - (pontoX + 500);
               int c1 = a1 * (pontoX - 500) + b1 * pontoY;


               // Line CD represented as a2x + b2y = c2 
               int a2 = (pontoFY + 500) - (pontoFY - 500);
               int b2 = pontoFX - pontoFX;
               int c2 = a2 * pontoFX + b2 * (pontoFY - 500);

               int determinant = a1 * b2 - a2 * b1;


               int x = (b2 * c1 - b1 * c2) / determinant;
               int y = (a1 * c2 - a2 * c1) / determinant;
               pontoIntersecção = new Ponto(x, y); 

           }

           */

    }
}
