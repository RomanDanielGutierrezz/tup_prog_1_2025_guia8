using System.ComponentModel;

namespace EJ1
{
    internal class Program
    {
        #region variables
        static int contador = 0, acumulador = 0, maximo = 0, minimo = 1000;
        static int CantIngreso, Valor, Promedio = 0;
        #endregion
        static void Main(string[] args)
        {
            
            #region Menu
            Console.WriteLine("1 - Procesar un solo numero");
            Console.WriteLine("2 - Procesar varios numero");
            Console.WriteLine("3 - Mostrar maximo y minimo");
            Console.WriteLine("4 - Mostrar Promedio");
            Console.WriteLine("5 - Mostrar Cantidad de numeros ingresados");
            Console.WriteLine("6 - Reiniciar Variables");
            int entrada = Convert.ToInt32(Console.ReadLine());
            #endregion
            switch (entrada)
            {
                case 1:
                    {
                        Console.WriteLine("Ingresar Valor");
                        Valor = Convert.ToInt32(Console.ReadLine());
                        acumulador += Valor;
                        contador++;
                    }
                    break;
                case 2: 
                    {
                        #region Solicitar cantidad datos
                        Console.WriteLine("Ingresar cantidad de datos");
                        CantIngreso = Convert.ToInt32(Console.ReadLine());
                        #endregion
                        #region Iteracion
                        for (int i = 1; i <= CantIngreso; i++)
                        {
                            #region Solicitar y acumular
                            Console.WriteLine("Ingresar Valor");
                            Valor = Convert.ToInt32(Console.ReadLine());
                            acumulador += Valor;
                            #endregion
                            #region Maximo y Minimo
                            if (Valor > maximo)
                                maximo = Valor;

                            if (Valor < minimo)
                                minimo = Valor;
                            #endregion
                            contador++;
                        }
                        #endregion
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
                        #region Verificar
                        if (maximo != 0)
                        {
                            #region Promedio
                            Promedio = acumulador / contador;
                            #endregion
                        }
                        #endregion
                        Console.WriteLine($"El promedio es {Promedio}");
                    }break;
                case 5:
                    {
                        Console.WriteLine($"La cantidad de numero ingresados es {contador}");
                    }break;
                case 6:
                    {
                        contador = 0; acumulador = 0; maximo = 0; minimo = 1000;
                        CantIngreso = 0; Valor = 0; Promedio = 0;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Numero no valido");
                    }break;
            }
        }
    }
}
