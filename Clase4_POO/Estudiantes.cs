using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Clase4_POO
{
    internal class Estudiantes
    {

        // get return de un valor
        // set para asignar un valor a una variable
        // delimitadores de accesos public private protected
        private static string[] nombre = new string[3];
        private static byte[] edad = new byte[3];
        private static float[] notas = new float[3];

        private static byte indice = 0;

        public static void ConsultarEstudiantes()
        {
            bool existe = false;
            Console.WriteLine("Digite el nombre");
            string nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre.Equals(nombre[i]))
                {
                    Console.WriteLine($"Nombre existe y tiene {edad[i]} años");
                    existe = true;
                    break;
                }

            }
            if (!existe)
            {
                Console.WriteLine("Estudiante no existe");
            }
        }
        public static void AgregarEstudiantes()
        {
            char op = 'n';

            try
            {
                do
                {
                    Console.WriteLine("Ingrese al Estudiante {0}: ", (indice + 1));
                    nombre[indice] = Console.ReadLine();
                    Console.WriteLine("ingrese la edad");
                    edad[indice] = byte.Parse(Console.ReadLine());
                    indice++;
                    Console.WriteLine("Desea Agregar otro Estudiante (s/n)");
                    op = Convert.ToChar(Console.ReadLine().ToLower());
                } while (!op.Equals('n'));
            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex);
                Console.Read();
            }

        }

        public static void ImprimirEstudiantes()
        { Console.Clear();
            Console.WriteLine(" Nombre          Edad");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"Nombre: {nombre[i]} Edad: {edad[i]}");
            }
            Console.WriteLine("----------------------------");

        }
        public static void BorrarEstudiantes() {

            bool existe = false;
            Console.WriteLine("Digite el nombre");
            string _nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if (_nombre.Equals(nombre[i]))
                {
                    nombre[i] = string.Empty;
                    edad[i] = 0;
                    notas[i] = 0;
                    Console.WriteLine($"Estudiante {nombre[i]} ha sido eliminado");
                    existe = true;
                    break;
                }

            }
            if (!existe)
                Console.WriteLine("Estudiante no existe");

        }
        public static void ModificarEstudiantes() {
            bool existe = false;
            Console.WriteLine("Digite el nombre");
            string _nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if (_nombre.Equals(nombre[i]))
                {
                    Console.WriteLine("Ingrese al Estudiante : ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("ingrese la edad");
                    edad[i] = byte.Parse(Console.ReadLine());
                    Console.WriteLine($"Estudiante {nombre[i]} ha sido actualizado");
                    existe = true;
                    break;
                }

            }
            if (!existe)
                Console.WriteLine("Estudiante no existe");
        }

        protected static void Calcularpromedio()
        {

        }

    }
}
