using POO.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        private static void Main()
        {
            // Empleado
            Console.WriteLine("Ingrese el nombre del Empleado:");
            string nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del Empleado:");
            double salarioEmpleado;
            while (!double.TryParse(Console.ReadLine(), out salarioEmpleado))
            {
                Console.WriteLine("Ingrese un salario válido:");
            }

            //instancia de los datos empleado
            Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);

            //Gerente
            Console.WriteLine("\nIngrese el nombre del Gerente:");
            string nombreGerente = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del Gerente:");
            double salarioGerente;
            while (!double.TryParse(Console.ReadLine(), out salarioGerente))
            {
                Console.WriteLine("Ingrese un salario válido:");
            }

            Console.WriteLine("Ingrese el departamento del Gerente:");
            string departamentoGerente = Console.ReadLine();

            // instancia de los datos gerente
            Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);


            // Mostrar información utilizando polimorfismo a través de la interfaz
            Console.WriteLine("Datos del Empleado:");
            MostrarInformacion(empleado);

            Console.WriteLine("\nDatos del Gerente:");
            MostrarInformacion(gerente);
            Console.ReadLine();
        }

        private static void MostrarInformacion(IMostrarInformacion entidad)
        {
            entidad.MostrarInformacionGeneral();
        }

    }
}
