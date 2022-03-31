using System;

namespace Colas_Dobles_Estaticas{
    class Program{
        string[] nombres = new string[5];
        int tamano = nombres.Length;
        string izquierda, derecha;
        public static void Main(string[] args){
            Console.Clear();
            int inicio = 0;
            int opc = 0;

            Console.WriteLine("*************** MENU DE OPCIONES DE COLA DOBLE ***************\n");

            Console.WriteLine("1. Insertar nombres.");
            Console.WriteLine("2. Eliminar nombres..");
            Console.WriteLine("3. Mostrar nombres.");
            Console.WriteLine("4. Salir.");

            switch(opc){
                case 1:
                    insertarNombres(ref inicio);
                    break;
            }
        }

        public static void insertarNombres(ref int inicio2){
            Console.WriteLine("********** INSERTAR NOMBRES POR LA DERECHA **********\n");

            Console.WriteLine("El tamaño de la cola es de " + nombres.Length + " nombres\n");

            Console.WriteLine("¿Por que lado desea insertar el nombre?");
            Console.WriteLine("1. Izquierda.");
            Console.WriteLine("2. Derecha");
            int lado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa nombre de tu amigo: ");
            Console.Write("-> ");
            nombres = Convert.ToInt32(Console.ReadLine());

            if(inicio2 == 0){
                inicio = tamano / 2;
                izquierda = inicio - 1;
                derecha = inicio + 1;

                nombres[inicio] = nombres;
            }
        }
    }
}