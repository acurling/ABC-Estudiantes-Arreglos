using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_POO
{
    internal class Menu
    {
        int opcion;

        public void principal()
        {
            opcion = 0;
            do
            {
                
                Console.WriteLine("1- Agregar Estudiantes");
                Console.WriteLine("2- Agregar notas");
                Console.WriteLine("3- Consultar Estudiantes");
                Console.WriteLine("4- Modificar Estudiantes");
                Console.WriteLine("5- Borrar Estudiantes");
                Console.WriteLine("6- Imprimir Estudiantes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Estudiantes.AgregarEstudiantes();
                        break;
                    case 2: break;
                    case 3: Estudiantes.ConsultarEstudiantes(); break;
                    case 4: Estudiantes.ModificarEstudiantes();  break;
                    case 5: Estudiantes.BorrarEstudiantes(); break;
                    case 6: Estudiantes.ImprimirEstudiantes();
                        break;
                    default:
                        break;
                }
            } while (opcion != 7);
        }

    }
}
