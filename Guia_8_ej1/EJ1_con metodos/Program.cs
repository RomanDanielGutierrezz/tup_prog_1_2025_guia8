using System.ComponentModel;

namespace EJ1
{
    internal class Program
    {
        #region resolución del problema
        static int contador, acumulador, maximo, minimo;
        static int CantIngreso;
        static bool salir;
        static void Inicializar()
        {
            contador = 0; acumulador = 0; maximo = 0; minimo = 1000;
            CantIngreso = 0;  
            salir = false;
        }
        static void SolicitarIngresos()
        {
            Console.WriteLine("Ingresar cantidad de datos");
            CantIngreso = Convert.ToInt32(Console.ReadLine());
        }
        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;
           
            if (contador==1 ||  valor > maximo)
                maximo = valor;

            if (contador==1 || valor < minimo)
                minimo = valor;
        }
        static double CalcularPromedio()
        {
            double promedio = 0;

            if (contador > 0)
            {
                promedio = 1d * acumulador / contador;
            }

            return promedio;
        }
        #endregion

        #region impresion de pantalla
        static int MostrarPantallSolicitarOpcionMenu()
        {

            Console.Clear();
            Console.WriteLine("1 - Procesar un solo numero");
            Console.WriteLine("2 - Procesar varios numero");
            Console.WriteLine("3 - Mostrar maximo y minimo");
            Console.WriteLine("4 - Mostrar Promedio");
            Console.WriteLine("5 - Mostrar Cantidad de numeros ingresados");
            Console.WriteLine("6 - Reiniciar Variables\n");

            int entrada = Convert.ToInt32(Console.ReadLine());
            return entrada;
        }

        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();

            Console.WriteLine("Ingrese valor");
            int valor = Convert.ToInt32(Console.ReadLine());

            RegistrarValor(valor);

        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();

            Console.WriteLine(" Cálculo del promedio \n\n");


            double promedio=CalcularPromedio();
            Console.WriteLine($"El promedio es {promedio}");

            Console.WriteLine("Presione una tecla cualquier para continuar");
            Console.ReadKey();

        }

        #endregion

        static void Main(string[] args)
        {
            Inicializar();

            int op = MostrarPantallSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        {
                            SolicitarIngresos();
                            for (int i = 1; i <= CantIngreso; i++)
                            {
                                Console.WriteLine("Ingresar Valor");
                                int valor = Convert.ToInt32(Console.ReadLine());
                                RegistrarValor(valor);
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine($"El valor maximo es {maximo}");
                            Console.WriteLine($"El valor minimo es {minimo}");
                        }
                        break;
                    case 4:
                        {
                            MostrarPantallaCalcularYMostrarPromedio();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine($"La cantidad de numero ingresados es {contador}");
                        }
                        break;
                    case 6:
                        {
                            Inicializar();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Numero no valido\n");
                            salir = true;
                        }
                        break;
                }

                if(op!=-1)
                    op = MostrarPantallSolicitarOpcionMenu();
            }
        }
    }
}