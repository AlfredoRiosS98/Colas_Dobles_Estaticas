using System;

namespace Colas_Dobles_Estaticas
{
    class Program
    {
        public static string[] nombres = new string[35];
        public static int tamano = 35, inicio;
        public static int izquierda, derecha;
        public static string elemento;
        public static int c = 0;

        public static void Main(string[] args)
        {
            int opc = 0, O;

            do
            {
                Console.Clear();
                Console.WriteLine("********** MENU DE OPCIONES DE COLA DOBLE **********\n");

                Console.WriteLine("1. Insertar nombres.");
                Console.WriteLine("2. Eliminar nombres..");
                Console.WriteLine("3. Mostrar nombres.");
                Console.WriteLine("4. Salir.");

                Console.WriteLine("\n¿Qué opción desea realizar?");
                Console.Write("-> ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        insertarNombres();
                        break;
                    case 2:
                        eliminarNombres();
                        break;
                    case 3:
                        imprimir();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n********** Saliendo del programa. **********\n");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n********** Saliendo del programa **********\n");
                        break;
                }
                
                Console.WriteLine("¿Desea realizar otra acción en el ménu? 1. Si / 2. No");
                Console.Write("-> ");
                O = Convert.ToInt32(Console.ReadLine());      
            } while (O != 2);
        }

        public static void insertarNombres()
        {
            int opci;
            do
            {
                Console.Clear();
                c = c + 1;
                Console.WriteLine("********** INSERTAR NOMBRES POR LA DERECHA **********\n");

                Console.WriteLine("El tamaño de la cola es de " + tamano + " nombres\n");

                Console.WriteLine("¿Por que lado desea insertar el nombre?");
                Console.WriteLine("1. Derecha.");
                Console.WriteLine("2. Izquierda\n");
                Console.Write("-> ");
                int lado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre de un amigo.");
                Console.Write("-> ");
                elemento = Console.ReadLine();

                if (inicio == 0)
                {
                    inicio = tamano / 2;
                    izquierda = inicio - 1;
                    derecha = inicio + 1;

                    nombres[inicio] = nombres[c];

                }

                if (lado.Equals(1))
                {
                    if (derecha >= tamano)
                    {
                        Console.WriteLine("Cola del lado derecho llena.");
                        Console.WriteLine("Presione la tecla <enter> para continuar.");
                        Console.ReadKey();
                    }
                    else
                    {
                        nombres[derecha] = elemento;
                        derecha = derecha + 1;
                    }
                }
                else if (lado.Equals(2))
                {
                    if (izquierda < 0)
                    {
                        Console.WriteLine("Cola del lado izquierdo llena.");
                        Console.WriteLine("Presione la tecla <enter> para continuar.");
                        Console.ReadKey();
                    }
                    else
                    {
                        nombres[izquierda] = elemento;
                        izquierda = izquierda - 1;
                    }
                }

                Console.WriteLine("¿Desea ingresar otro nombre? 1. Si / 2. No");
                Console.Write("-> ");
                opci = Convert.ToInt32(Console.ReadLine());
            } while (opci != 2);
        }

        public static void eliminarNombres(){
           Console.Clear();
           Console.WriteLine("********** ELIMINAR NOMBRES DE TUS AMIGOS **********\n");
           
           Console.WriteLine("¿De que lado desea eliminar el nombre? 1. Derecha / 2. Izquierda");
           Console.Write("-> ");
           int lad =Convert.ToInt32(Console.ReadLine());

           if(lad.Equals(1)){
               Console.WriteLine("Eliminando nombres por el lado derecho\n");

               if(derecha == 0){
                   Console.WriteLine("Cola del lado derecho vacia.");
                   Console.WriteLine("Presione la tecla <enter> para continuar.");
                   Console.ReadKey();
               } else{
                   nombres[derecha - 1] = "";
                   derecha = derecha - 1;

                   if(izquierda == derecha){
                       derecha = 0;
                   }
               }
               }
           else if(lad.Equals(2)){
                Console.WriteLine("Eliminando nombres por el lado izquierdo.\n");

                if(izquierda == (tamano - 1)){
                    Console.WriteLine("Cola del lado izquierdo vacia.");
                    Console.WriteLine("Presione la tecla <enter> para continuar.");
                    Console.ReadKey();
                } else{
                    nombres[izquierda + 1] = "";
                    izquierda = izquierda + 1;

                    if(izquierda == derecha){
                        izquierda = tamano;
                    }
                }
           }
        }

        public static void imprimir()
        {
            Console.Clear();
            Console.WriteLine("********** MOSTRAR NOMBRES DE TUS AMIGOS **********\n");
            
            Console.WriteLine("¿Que lado de la pila desea recorrer? 1.Derecha / 2.Izquierda");
            Console.Write("-> ");
            int lad = Convert.ToInt32(Console.ReadLine());

            if(lad == 1){
                Console.Clear();
                Console.WriteLine("Nombres de la cola del lado derecho.");
                for(int i = inicio; i < derecha;i++){
                    Console.WriteLine(nombres[i]);
                }
            } else if(lad == 2){
                Console.Clear();
                Console.WriteLine("Nombres de la cola del lado izquierdo.");
                for(int a = inicio; a > izquierda; a--){
                    Console.WriteLine(nombres[a]);
                }
            }

            Console.WriteLine("\nPresione la tecla enter para continuar.");
            Console.ReadKey();
        }

    }
}
