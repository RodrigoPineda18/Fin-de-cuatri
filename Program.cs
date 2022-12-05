using System;

namespace Main
{
    public class
    {
        static void Main(string[] args)
        {

            int opcion, X = 0, aux = 0;
            float prom, Z;
            int[] numeros = new int[10];
            int[] arrayAux = new int[10];

            numeros = llenarNumeros();

           
            Console.Clear();

            do
            {



                opciones();
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (opcion)
                {


                    case 1:

                        numeros = regresarInv(numeros);

                        mostrarArray(numeros);

                        segir();
                        break;


                    case 2:
                        X = 0;
                        for (int i = 1; i < 10; i++)
                        {
                            aux = numeros[i - 1];

                            if (aux > numeros[i])
                            {
                                X++;
                            }

                        }

                        if (X > 0)
                        {
                            Console.WriteLine("\nLa lista de numeros no esta ordenado de menor a mayor");
                        }
                        else
                        {
                            Console.WriteLine("\nLa lista de numeros si esta ordenada de menor a mayor");
                        }

                        segir();
                        break;

                    case 3:
                        X = 0;
                        for (int i = 1; i < 10; i++)
                        {
                            aux = numeros[i - 1];

                            if (aux > numeros[i])
                            {
                                X++;
                            }

                        }

                        if (X > 0)
                        {
                            Console.WriteLine("\nLa lista de numeros no esta extrictamente ordenado de forma creciente");
                        }
                        else
                        {
                            Console.WriteLine("\nLa lista de numeros si esta extrictamente ordenada de forma creciente");
                        }

                        segir();
                        break;

                    case 4:
                        X = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            aux = numeros[i];
                            for (int j = 0; j < 10; j++)
                            {

                                if (aux == numeros[j] && j != i)
                                {
                                    X++;
                                }
                            }
                        }

                        if (X != 0)
                        {
                            Console.WriteLine("\nExisten numeros repetidos en la lista de numeros");
                        }
                        else
                        {
                            Console.WriteLine("\nNo existen numeros repetidos en la lista de numeros");
                        }

                        segir();
                        break;

                    case 5:

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 10; j++)
                            {
                                aux = numeros[j - 1];
                                if (aux > numeros[j])
                                {
                                    aux = numeros[j];
                                    numeros[j] = numeros[j - 1];
                                    numeros[j - 1] = aux;
                                }
                            }
                        }


                        mostrarArray(numeros);
                        segir();
                        break;

                    case 6:
                        Console.Write("Ingrese el numero a comparar: \n- > ");
                        aux = int.Parse(Console.ReadLine());
                        X = 0;
                        for (int i = 0; i < 10; i++)
                        {

                            if (aux == numeros[i])
                            {
                                X++;
                            }
                        }

                        if (X > 0)
                        {
                            Console.WriteLine("\nEl numero ingresado si se encuantra en la lista de numeros");
                        }
                        else
                        {
                            Console.WriteLine("\nEl numero ingresado no se encuantra en la lista de numeros");
                        }


                        segir();
                        break;

                    case 7:
                        Z = 0;
                        for (int i = 0; i < 10; i++)
                        {

                            Z = Z + numeros[i];

                        }
                        prom = Z / 10;

                        Console.WriteLine("\nEl promedio de la lista de numeros es: " + prom);

                        segir();
                        break;

                    case 8:

                        numeros = llenarNumeros();
                        segir();
                        break;

                    case 9:
                        Console.WriteLine("Adios, vuelva pronto");

                        break;

                    default:
                        Console.WriteLine("La opcion escogida no es valida \n presione cualquier tecla para continuar");

                        break;

                }
                Console.ReadKey();
            } while (opcion != 9);



        }

        public static void opciones()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la opcion a realizar \n");

            Console.WriteLine("1.- Intercambiar el orden del vector");

            Console.WriteLine("\n2.- Verificar que la lista este ordenada del menor al mayor");

            Console.WriteLine("\n3.- Averiguar si la lista esta ordenada extrictamente creciente ");

            Console.WriteLine("\n4.- Verificar si hay numeros repetidos");

            Console.WriteLine("\n5.- Ordenar de menor a mayor los elementos");

            Console.WriteLine("\n6.- Ingresar un numero para verificar si este existe en la lista");

            Console.WriteLine("\n7.- Hallar el promedio de la lista de numeros");

            Console.WriteLine("\n8.- Volver a llenar la lista del numeros");

            Console.Write("\n9.- Salir \n- > ");
        }

        public static void mostrarArray(int[] array)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + array[i]);
            }

        }

        public static int[] llenarNumeros()
        {
            int[] numero = new int[10];
            Console.WriteLine("Ingrese en forma de lista 10 numeros: \n");

            for (int i = 1; i < 11; i++)
            {

                Console.Write("Ingrese el " + i + " numero: ");
                numero[i - 1] = int.Parse(Console.ReadLine());

            }

            return numero;
        }

        public static void segir()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar");
        }

        public static int[] regresarInv(int[] array)
        {
            int[] auxArray = new int[10];
            int Y = 0;
            for (int i = 9; i > -1; i--)
            {
                auxArray[Y] = array[i];
                Y++;
            }
            return auxArray;


        }

    }
}
