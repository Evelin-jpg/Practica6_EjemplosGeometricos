using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosGeometricos
{
   public class AreasGeo
    {
        private decimal area;

        public decimal Area
        {
            get
            {
              return area;
            }


            set
            { 
              area = value; 
            }
        }

        //Constructores
        public AreasGeo()
        {
            area = 0;
        }

        public decimal Cuadrado(decimal lado)
        {
            area = lado * lado;
            return area;
        }

        public decimal Triangulo (decimal b, decimal h)
        {
            area = (b*h)/2;
            return area;
        }

        public decimal Rectangulo (decimal b, decimal h, decimal value)
        {
            area = b*h;
            return area;
        }

        public decimal Rombo (decimal D, decimal d, decimal value, decimal value2)
        {
            area = (D*d)/2;
            return area;
        }

        public decimal Pentagono (decimal p, decimal a, decimal value, decimal value2, decimal value3)
        {
            area = (p*a)/2;
            return area;
        }

        public decimal Hexagono (decimal p, decimal a, decimal value, decimal value2, decimal value3, decimal value4)
        {
            area = (p * a) / 2;
            return area;
        }

        public decimal Circulo(decimal radio)
        {
         
            area = Math.PI * radio * radio;
            return area;
        }

        public decimal Trapecio(decimal B, decimal b, decimal h,decimal value, decimal value2, decimal value3, decimal value4, decimal value5, decimal value6)
        {
            area = b*b*h / 2;
            return area;
        }

    }
}
