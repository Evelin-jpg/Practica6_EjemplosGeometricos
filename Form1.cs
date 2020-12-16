using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosGeometricos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Cuadrado(numDato.Value);
            lblArea.Text = resultado + "";
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Triangulo(numDato.Value, numDato2.Value);
            lblArea2.Text = resultado + "";

        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Rectangulo(numDato.Value, numDato2.Value, numDato3.Value);
            lblArea3.Text = resultado + "";

        }

        private void btnAreaRombo_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Rombo(numDato.Value, numDato2.Value, numDato3.Value, numDato4.Value);
            lblArea4.Text = resultado + "";
        }

        private void btnAreaPentagono_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Pentagono(numDato.Value, numDato2.Value, numDato3.Value, numDato4.Value, numDato5.Value);
            lblArea5.Text = resultado + "";
        }

        private void btnAreaHexagono_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Hexagono(numDato.Value, numDato2.Value, numDato3.Value, numDato4.Value, numDato5.Value, numDato6.Value);
            lblArea6.Text = resultado + "";
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Circulo(numDato.Value, numDato2.Value, numDato3.Value, numDato4.Value, numDato5.Value, numDato6.Value, numDato7.Value);
            lblArea7.Text = resultado + "";
        }

        private void btnAreaTrapecio_Click(object sender, EventArgs e)
        {
            AreasGeo a = new AreasGeo();
            decimal resultado = a.Trapecio(numDato.Value, numDato2.Value, numDato3.Value, numDato4.Value, numDato5.Value, numDato6.Value, numDato7.Value, numDato8.Value);
            lblArea8.Text = resultado + "";
        }
    }
    
}
