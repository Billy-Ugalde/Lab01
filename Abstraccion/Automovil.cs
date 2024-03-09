using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Abstraccion
{
    public class Automovil : Vehiculo, IAutomovil
    {

        public string Modelo { get; set; }
        public int placa { get; set; }
        public string color { get; set; }

        public void agregar()
        {
            Console.WriteLine("Agregando");
        }

        public void Editar()
        {
            Console.WriteLine("Editando");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminar");
        }





    }
}
