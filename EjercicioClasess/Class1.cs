using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasess
{
    internal class SuperPoder: SuperHeroe 
    {
        public bool descripcion { get; set; }

        public bool nivel { get; set; }

        public void Imprimir ()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"IdentidadSecreta: {IdentidadSecreta}");
            Console.WriteLine($"ciudad: {ciudad}");
            Console.WriteLine($"puedeVolar:  {puedeVolar}");
            Console.WriteLine($"superPoder: {superPoder}");
            Console.WriteLine($"descripcion: {descripcion}");
            Console.WriteLine($"nivel: {nivel}");
      
        }
    }
}

 
