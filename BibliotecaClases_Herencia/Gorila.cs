using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases_Herencia
{
    // Los metodos dentro de la clase Mamiferos estaran tambien
    // en la clase Gorila explicitamente
    public class Gorila : Mamifero
    {
        // Constructor parametrizado
        public Gorila (String nombreGorila) : base (nombreGorila) { }

        // Metodo Publico
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
