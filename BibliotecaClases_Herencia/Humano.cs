﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases_Herencia
{
    // Los metodos dentro de la clase Mamiferos estaran tambien
    // en la clase Humano explicitamente
    public class Humano : Mamifero
    {
        // Constructor parametrizado
        public Humano(String nombreHumano) : base(nombreHumano) { }
        
        // Metodo Publico
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
}
