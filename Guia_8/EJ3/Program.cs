using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace EJ3
{
    internal class Program
    {
        #region Variables
        static string nombre0;
        static string nombre1;
        static string nombre2;
        static int numerolibreta0;
        static int numerolibreta1;
        static int numerolibreta2;
        static int orden;
        static int acumulador;
        #endregion
        static void Main(string[] args)
        {
            bool sigue = false;
            while (!sigue)
            {
                MostrarPantallaSolicitarOpcionMenu();
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            MostrarPantallaSolicitarAlumnos();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            MostrarPantallaMostrarListaOrdenada();
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            sigue = true;
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Opcion no valida, por favor intente nuevamente.");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        #region Calculo
        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta, int paso)
        {
            acumulador++;
            switch (paso)
            {
                case 1:
                    {
                        nombre0 = nombre;
                        numerolibreta0 = numeroLibreta;
                    }
                    break;
                case 2:
                    {
                        nombre1 = nombre;
                        numerolibreta1 = numeroLibreta;
                    }
                    break;
                case 3:
                    {
                        nombre2 = nombre;
                        numerolibreta2 = numeroLibreta;
                    }
                    break;
            }
        }
        #endregion
        #region Pantalla
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Registrar las notas de los tres alumnos");
            Console.WriteLine("2 - Mostrar lista ordenada");
            Console.WriteLine("3 - Salir");
          
        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("Ingresar Nombre de alumno y Nota 1mer alumno");
            nombre0 = Console.ReadLine();
            numerolibreta0 = Convert.ToInt32(Console.ReadLine());
            RegistrarNombreYNumeroLibreta(nombre0, numerolibreta0, 1);
            Console.WriteLine("Ingresar Nombre de alumno y Nota 2do alumno");
            nombre1 = Console.ReadLine();
            numerolibreta1 += Convert.ToInt32(Console.ReadLine());
            RegistrarNombreYNumeroLibreta(nombre1, numerolibreta1, 2);
            Console.WriteLine("Ingrese Nombre de alumno y Nota 3cer alumno");
            nombre2 = Console.ReadLine();
            numerolibreta2 = Convert.ToInt32(Console.ReadLine());
            RegistrarNombreYNumeroLibreta(nombre2, numerolibreta2, 3);
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (numerolibreta0 > numerolibreta1)
            {
                if (numerolibreta1 < numerolibreta2)
                {
                    Console.WriteLine($"{nombre0}: {numerolibreta0}");
                    Console.WriteLine($"{nombre1}: {numerolibreta1}");
                    Console.WriteLine($"{nombre2}: {numerolibreta2}");
                }
                else if (numerolibreta2 > numerolibreta0)
                {
                    Console.WriteLine($"{nombre2}: {numerolibreta2}");
                    Console.WriteLine($"{nombre0}: {numerolibreta0}");
                    Console.WriteLine($"{nombre1}: {numerolibreta1}");
                }
                else
                {
                    Console.WriteLine($"{nombre0}: {numerolibreta0}");
                    Console.WriteLine($"{nombre2}: {numerolibreta2}");
                    Console.WriteLine($"{nombre1}: {numerolibreta1}");
                }
            }
            else
            {
                if (numerolibreta2 > numerolibreta0)
                {
                    Console.WriteLine($"{nombre2}: {numerolibreta2}");
                    Console.WriteLine($"{nombre0}: {numerolibreta0}");
                    Console.WriteLine($"{nombre1}: {numerolibreta1}");
                }
                else if (numerolibreta2 > numerolibreta1)
                {
                    Console.WriteLine($"{nombre2}: {numerolibreta2}");
                    Console.WriteLine($"{nombre1}: {numerolibreta1}");
                    Console.WriteLine($"{nombre0}: {numerolibreta0}");
                }
                else
                {
                    Console.WriteLine($"{nombre1}: {numerolibreta1}");
                    Console.WriteLine($"{nombre2}: {numerolibreta2}");
                    Console.WriteLine($"{nombre0}: {numerolibreta0}");
                }
            }
        }
        #endregion
    }
}
