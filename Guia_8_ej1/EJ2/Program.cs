namespace EJ2
{
    internal class Program
    {
        #region Varibles
        static int edad0;
        static int edad1;
        static int edad2;
        static int edad3;
        static double monto;
        static double porcentaje0;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double monto0;
        static double monto1;
        static double monto2;
        static double monto3;
        static double acumulador;
        static void Inicializar()
        {
            edad0 = 0;
            edad1 = 0;
            edad2 = 0;
            edad3 = 0;
            monto = 0;
            porcentaje0 = 0;
            porcentaje1 = 0;
            porcentaje2 = 0;
            porcentaje3 = 0;
            monto0 = 0;
            monto1 = 0;
            monto2 = 0;
            monto3 = 0;
            acumulador = 0;
        }
        #endregion
        #region Calculos
        static void RegistrarEdades(int edad, int nmrNiña)
        {
            acumulador += edad;
            switch (nmrNiña)
            {
                case 1:
                    edad0 = edad;
                    break;
                case 2:
                    edad1 = edad;
                    break;
                case 3:
                    edad2 = edad;
                    break;
                case 4:
                    edad3 = edad;
                    break;
            }
        }
        static double RegistrarMontoARepartir(double total)
        {
            monto = total;
            return monto;
        }
        static double CalcularMontoYPorcetajesARepartir()
        {
            porcentaje0 = (edad0 / acumulador) * 100;
            porcentaje1 = (edad1 / acumulador) * 100;
            porcentaje2 = (edad2 / acumulador) * 100;
            porcentaje3 = (edad3 / acumulador) * 100;
            monto0 = (porcentaje0 / 100) * monto;
            monto1 = (porcentaje1 / 100) * monto;
            monto2 = (porcentaje2 / 100) * monto;
            monto3 = (porcentaje3 / 100) * monto;
            return porcentaje0 + porcentaje1 + porcentaje2 + porcentaje3 + monto0 + monto1 + monto2 + monto3;
        }
        #endregion
        #region Pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            int op = 0;
            Console.Clear();
            Console.WriteLine("1 - Indicar las edades\n");
            Console.WriteLine("2 - Indicar Monto\n");
            Console.WriteLine("3 - Mostrar monto y porcentaje a repartir\n");
            Console.WriteLine("4 - Salir\n");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out op))
            {
                return op;
            }
            else
            {
                return 0;
            }
        }
        static void MostrarPantallaMontoARepartir()
        {
            bool pasa = false;
            while (!pasa)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el monto a repartir\n");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out double monto))
                {
                    if (monto > 1)
                    {
                        pasa = true;
                        RegistrarMontoARepartir(monto);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("El monto debe ser mayor que 0\n");
                        Console.WriteLine("Pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El monto ingresado no es valido\n");
                    Console.WriteLine("Pulse una tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
        static void MostrarPantallaSolicitarEdades()
        {
            Console.Clear();
            int edad = 0;
            Console.WriteLine("Complete las edades\n");
            Console.Write("Edad 1:");
            edad = Convert.ToInt32(Console.ReadLine());
            RegistrarEdades(edad, 1);
            Console.Write("Edad 2:");
            edad = Convert.ToInt32(Console.ReadLine());
            RegistrarEdades(edad, 2);
            Console.Write("Edad 3:");
            edad = Convert.ToInt32(Console.ReadLine());
            RegistrarEdades(edad, 3);
            Console.Write("Edad 4:");
            edad = Convert.ToInt32(Console.ReadLine());
            RegistrarEdades(edad, 4);
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentaje()
        {
            Console.Clear();
            Console.WriteLine($"Los Montos a repartir son:\n");
            Console.WriteLine($"1mer niña {monto0:f2}");
            Console.WriteLine($"2da niña {monto1:f2}");
            Console.WriteLine($"3cer niña {monto2:f2}");
            Console.WriteLine($"4ta niña {monto3:f2}\n");
            Console.WriteLine($"Los respectivos porcentajes son {porcentaje0:f2}%, {porcentaje1:f2}%, {porcentaje2:f2}%, {porcentaje3:f2}%\n");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }
        #endregion
        
        static void Main(string[] args)
        {
            int op = 0;
            while (op != -1)
            {
                op = MostrarPantallaSolicitarOpcionMenu();
                switch (op)
                {
                    case 1:
                        {
                            MostrarPantallaSolicitarEdades();
                        }
                        break;
                    case 2:
                        {
                            MostrarPantallaMontoARepartir();
                        }
                        break;
                    case 3:
                        {
                            CalcularMontoYPorcetajesARepartir();
                            MostrarPantallaCalcularMostrarMontoYPorcentaje();
                        }
                        break;
                    case 4:
                        {
                            op = -1;
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Opción no válida\n");
                            Console.WriteLine("Pulse una tecla para continuar");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
