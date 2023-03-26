using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases_Herencia
{
    // Los metodos dentro de la clase Mamiferos estaran tambien
    // en la clase Caballo explicitamente
    public class Caballo : Mamifero
    {
        // base() : Llamamos al constructor de la clase base o padre (Mamifero), desde
        // el constructor de la clase heredera para poder pasarle
        // el valor almacenado en el constructor Caballo, que sera el valor del parametro nombre de 
        // la clase Mamifero que se almacenara en el miembro nombreSerVivo.
        public Caballo(String nombreCaballo) : base(nombreCaballo) { }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
}
