using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Herencia
{
    public  class Figura
    {
        public float largo { get; set; }
        public float ancho { get; set; }
        public string color { get; set; }
        public string nombre { get; set; }

        public void calcularArea(float largo, float ancho )
        {
            Console.WriteLine("Calculando area");
        }
    }
}
