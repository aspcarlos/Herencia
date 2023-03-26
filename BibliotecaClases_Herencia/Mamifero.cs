using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BibliotecaClases_Herencia
{
    public class Mamifero
    {
        // Miembros Privativos
        private String nombreSerVivo;

        // Constructor Parametrizado
        public Mamifero(String nombre) 
        {
            nombreSerVivo = nombre;
        }

        // Metodos Publicos
        // Estos metodos son heredados por cualquiera de las clases herederas, por lo tanto,
        // los objetos instanciados pertenecientes a las clases las podran usar.
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");

        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es:\t" + nombreSerVivo);
        }
    }
}
