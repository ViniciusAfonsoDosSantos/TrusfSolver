namespace Software_Trelisa
{
    public partial class Form1 : Form
    {
        List<Barra> listaBarras = new List<Barra>();
        List<Ponto> listaPontos = new List<Ponto>();
        TextBox txtAngulo;
        bool Drag, encontrou;
        int StartX, StartY, CurrentX, CurrentY, endX, endY;
        double raioCirculo = 35.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbCriar.Checked == true & rbBarras.Checked == true)
            {
                Drag = true;
                StartX = e.X;
                StartY = e.Y;

                //Gancho Ponto Inicial
                foreach (Ponto ponto in listaPontos)
                {
                    if (StartX <= (ponto.valorX + raioCirculo) & StartX >= (ponto.valorX - raioCirculo) &
                        StartY <= (ponto.valorY + raioCirculo) & StartY >= (ponto.valorY - raioCirculo))
                    {
                        Drag = true;
                        StartX = ponto.valorX;
                        StartY = ponto.valorY;
                        break;
                    }
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbCriar.Checked == true & rbBarras.Checked == true)
            {
                Graphics g = panel1.CreateGraphics();
                Pen myPen = new Pen(Color.Green, 8);

                CurrentX = e.X;
                CurrentY = e.Y;
                if (Drag == true)
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.DrawLine(myPen, StartX, StartY, CurrentX, CurrentY);
                    CurrentX = e.X;
                    CurrentY = e.Y;
                }

                g.Dispose();
                myPen.Dispose();
            }

            txtVisualiza.Text = e.X.ToString() + "," + e.Y.ToString();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rbCriar.Checked == true & rbBarras.Checked == true)
            {

                Drag = false;
                endX = e.X;
                endY = e.Y;

                //Gancho Ponto Final
                foreach (Ponto ponto in listaPontos)
                {
                    if (e.X <= (ponto.valorX + raioCirculo) & e.X >= (ponto.valorX - raioCirculo) &
                        e.Y <= (ponto.valorY + raioCirculo) & e.Y >= (ponto.valorY - raioCirculo))
                    {
                        endX = ponto.valorX;
                        endY = ponto.valorY;
                        break;
                    }
                }

                Barra barra = new Barra(StartX, StartY, e.X, e.Y, 0);
                VerificaPontoExiste(barra);
                listaBarras.Add(barra);

                DesenhaBarras();
                AdicionaAngulo(barra);
            }
        }

        private void VerificaPontoExiste(Barra barra)
        {
            Ponto ponto1 = new Ponto(StartX, StartY);
            Ponto ponto2 = new Ponto(endX, endY);

            foreach (Ponto ponto in listaPontos)
            {
                if (ponto.valorX == ponto1.valorX & ponto.valorY == ponto1.valorY)
                {
                    encontrou = true;
                    ponto.barrasPonto.Add(barra);
                    break;
                }
                else
                {
                    encontrou = false;
                }
            }

            if (encontrou == false)
            {
                listaPontos.Add(ponto1);
                ponto1.barrasPonto.Add(barra);
            }

            foreach (Ponto ponto in listaPontos)
            {
                if (ponto.valorX == ponto2.valorX & ponto.valorY == ponto2.valorY)
                {
                    encontrou = true;
                    ponto.barrasPonto.Add(barra);
                    break;
                }
                else
                {
                    encontrou = false;
                }
            }

            if (encontrou == false)
            {
                listaPontos.Add(ponto2);
                ponto2.barrasPonto.Add(barra);
            }

        }

        private void DesenhaBarras()
        {
            Graphics g = panel1.CreateGraphics();
            Pen myPen = new Pen(Color.Green, 8);
            g.Clear(panel1.BackColor);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            foreach (Barra barras in listaBarras)
            {
                g.DrawLine(myPen, barras.pontoInicialX, barras.pontoInicialY, barras.pontoFinalX, barras.pontoFinalY);
            }
            //g.DrawLine(myPen, StartX, StartY, endX, endY);
            g.Dispose();
            myPen.Dispose();
        }

        private void AdicionaAngulo(Barra barra)
        {
            txtAngulo = new TextBox();
            txtAngulo.Width = 50;
            txtAngulo.BorderStyle = BorderStyle.None;
            txtAngulo.ForeColor = Color.Red;
            txtAngulo.Tag = "Angulo";
            txtAngulo.MaxLength = 6;
            txtAngulo.DoubleClick += new EventHandler((sender, e) => txtAngulo_DoubleClick(sender, e, barra));

            if (barra.sentidoHorizontal == true && barra.sentidoVertical == true)
            {
                txtAngulo.Location = new Point(barra.pontoInicialX + 35, barra.pontoInicialY - 25);
                txtAngulo.Text = barra.angle.ToString("0.0000");
                panel1.Controls.Add(txtAngulo);

            }
            else if (barra.sentidoHorizontal == true && barra.sentidoVertical == false)
            {
                txtAngulo.Location = new Point(barra.pontoInicialX + 35, barra.pontoInicialY + 15);
                txtAngulo.Text = barra.angle.ToString("0.0000");
                panel1.Controls.Add(txtAngulo);

            }
            else if (barra.sentidoHorizontal == false && barra.sentidoVertical == false)
            {
                txtAngulo.Location = new Point(barra.pontoFinalX + 35, barra.pontoFinalY - 25);
                txtAngulo.Text = barra.angle.ToString("0.0000");
                panel1.Controls.Add(txtAngulo);
            }
            else if (barra.sentidoHorizontal == false && barra.sentidoVertical == true)
            {
                txtAngulo.Location = new Point(barra.pontoFinalX + 35, barra.pontoFinalY + 15);
                txtAngulo.Text = barra.angle.ToString("0.0000");
                panel1.Controls.Add(txtAngulo);
            }
        }

        private void txtAngulo_DoubleClick(object sender, EventArgs e, Barra barra)
        {
            barra.angle = Convert.ToDouble(txtAngulo.Text);

            if (listaPontos.Exists(x => x.valorX == barra.pontoFinalX & x.valorY == barra.pontoFinalY) == true)
            {
                Ponto pontoMuda = listaPontos.Find(x => x.valorX == barra.pontoFinalX & x.valorY == barra.pontoFinalY);

                if (pontoMuda.barrasPonto.Count != 0)
                {
                    foreach (Barra barraMuda in pontoMuda.barrasPonto)
                    {
                        if ((barra.sentidoHorizontal == true && barra.sentidoVertical == true) | (barra.sentidoHorizontal == false && barra.sentidoVertical == true))
                        {
                            barra.pontoFinalX = Convert.ToInt32(barra.pontoInicialX + barra.distancia * Math.Cos(Math.PI * barra.angle / 180.0));
                            barra.pontoFinalY = Convert.ToInt32(barra.pontoInicialY - barra.distancia * Math.Sin(Math.PI * barra.angle / 180.0));

                        }
                        else if ((barra.sentidoHorizontal == true && barra.sentidoVertical == false) | (barra.sentidoHorizontal == false && barra.sentidoVertical == false))
                        {
                            barra.pontoFinalX = Convert.ToInt32(barra.pontoInicialX + barra.distancia * Math.Cos(Math.PI * barra.angle / 180.0));
                            barra.pontoFinalY = Convert.ToInt32(barra.pontoInicialY + barra.distancia * Math.Sin(Math.PI * barra.angle / 180.0));

                        }

                    }

                    listaPontos.Remove(pontoMuda);
                }

                listaPontos.Remove(pontoMuda);
            }

            if ((barra.sentidoHorizontal == true && barra.sentidoVertical == true) | (barra.sentidoHorizontal == false && barra.sentidoVertical == true))
            {
                barra.pontoFinalX = Convert.ToInt32(barra.pontoInicialX + barra.distancia * Math.Cos(Math.PI * barra.angle / 180.0));
                barra.pontoFinalY = Convert.ToInt32(barra.pontoInicialY - barra.distancia * Math.Sin(Math.PI * barra.angle / 180.0));

            }
            else if ((barra.sentidoHorizontal == true && barra.sentidoVertical == false) | (barra.sentidoHorizontal == false && barra.sentidoVertical == false))
            {
                barra.pontoFinalX = Convert.ToInt32(barra.pontoInicialX + barra.distancia * Math.Cos(Math.PI * barra.angle / 180.0));
                barra.pontoFinalY = Convert.ToInt32(barra.pontoInicialY + barra.distancia * Math.Sin(Math.PI * barra.angle / 180.0));

            }


            foreach (Ponto ponto in listaPontos)
            {
                if (ponto.valorX == barra.pontoFinalX & ponto.valorY == barra.pontoFinalY)
                {
                    encontrou = true;
                    break;
                }
                else
                {
                    encontrou = false;
                }
            }

            if (encontrou == false)
            {
                Ponto ponto = new Ponto(barra.pontoFinalX, barra.pontoFinalY);
                listaPontos.Add(ponto);
            }

            Graphics g = panel1.CreateGraphics();
            Pen myPen = new Pen(Color.Green, 8);
            g.Clear(panel1.BackColor);
            foreach (Barra barras in listaBarras)
            {
                g.DrawLine(myPen, barras.pontoInicialX, barras.pontoInicialY, barras.pontoFinalX, barras.pontoFinalY);
            }
            g.Dispose();
            myPen.Dispose();
        }

        private void btnDesenha_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Green, 8);
            Graphics g = panel1.CreateGraphics();

            Pen myPen2 = new Pen(Color.Black, 2);
            Graphics v = panel1.CreateGraphics();
            foreach (Barra barra in listaBarras)
            {
                g.DrawLine(myPen, barra.pontoInicialX, barra.pontoInicialY, barra.pontoFinalX, barra.pontoFinalY);
            }
        }
    }
}

                /* -- Funções que n precisa
        if(barra.estainclinada == true) ---- Desenha ponto de intersecção
        {
            TextBox txtpontoInterseccao = new TextBox();
            txtpontoInterseccao.Location = new Point(barra.pontoIntersecção.valorX, barra.pontoIntersecção.valorY);
            txtpontoInterseccao.Text = "A";
            txtpontoInterseccao.Width = 10;
            panel1.Controls.Add(txtpontoInterseccao);
        }

    }


    foreach(Ponto ponto in listaPontos) --- Desenha barra vertical e horizontal no ponto
    {
        foreach(Barra barra in ponto.barrasPonto)
        {
            v.DrawLine(myPen2, barra.pontoInicialX, barra.pontoInicialY, barra.pontoFinalX, barra.pontoFinalY);
        }
    }


    int width = 25; ----- Desenha circulo, angulo.
            int height = 50;
            int startAngle = 0;
            int sweepAngle = Convert.ToInt32(barra.angle);
            g.DrawArc(myPen2, barra.pontoInicialX, barra.pontoInicialY - 25, width, height, startAngle, -90);


    v.Dispose();
    myPen2.Dispose();

    g.Dispose();
    myPen.Dispose();
}
*/
            
        