using BibliotecaClases_Herencia;

namespace EjemploBasico_Herencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instancia perteneciente a la clase Caballo
            Caballo Babieca = new Caballo();

            // Instancia perteneciente a la clase Humano
            Humano Juan = new Humano();

            // Instancia perteneciente a la clase Gorila
            Gorila Copito = new Gorila();

            // El objeto Babieca, solo podra usar los metodos de la clase base Mamifero y sus 
            // metodos exclusivos de la clase a la que pertenece, o sea, Caballo

            // Metodos heredados de la clase base Mamiferos
            Copito.cuidarCrias();
            Copito.respirar();

            // Metodos exclusivos de la clase heredera Caballo, a la que pertenece el objeto Copito
            Copito.trepar();

            // Mantener abierta la consola, para que lea las instrucciones
            Console.ReadLine();
        }
    }
}