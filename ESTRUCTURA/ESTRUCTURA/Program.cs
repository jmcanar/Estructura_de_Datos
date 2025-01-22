//EJERCICIO 1
//Función que calcule el número de elementos de una lista:
//La idea de este algoritmo es bastante sencilla, lo que tendremos q hacer para ver la longitud de
//una lista es simplemente recorrer la lista hasta el final e ir contando el número de saltos.
// El principal motivo por el que deberíamos implementar es que nos es que nos permite aprender y comprender permite aprender y comprender
//el manejo de los nodos.
//EJERCICIO 2
//Ivertir una lista Invertir una lista enlazada: enlazada:
//Implementar un método dentro de la Implementar un método dentro de la lista enlazada q lista enlazada que permita invertir los datos ue permita invertir los datos
//almacenados en una lista enlazada, es decir que almacenados en una lista enlazada, 
//es decir que el primer elemento pase a ser el último y el primer elemento pase a ser el último y el
//último pase a ser el primero, que el segundo sea el penúltimo y el penúltimo pase a ser el
//segundo y así segundo y así sucesivamente.
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        int opcion;
        do
        {
            Console.WriteLine ("*********************************************");
            Console.WriteLine ("........UNIVERSIDAD ESTATAL AMAZONICA........");
            Console.WriteLine ("*********************************************");
            Console.WriteLine ("......NOMBRE: JOSE MARCELO CAÑAR JUNCAL......");
            Console.WriteLine ("*********************************************");
            Console.WriteLine ("............ESTRUCTURA DE DATOS..............");
            Console.WriteLine ();
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar elemento a la lista");
            Console.WriteLine("2. EJERCICIO 1 (Contar elementos en la lista)");
            Console.WriteLine("3. EJERCICIO 2 (Invertir la lista)");
            Console.WriteLine("4. Mostrar la lista");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());//ToInt32: método en C# que se utiliza para convertir un valor a un entero de 32 bits (tipo int)./

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número para agregar a la lista: ");
                    int dato = Convert.ToInt32(Console.ReadLine());
                    lista.Agregar(dato);
                    break;
                case 2:
                    Console.WriteLine("Número de elementos en la lista: " + lista.ContarElementos());
                    break;
                case 3:
                    lista.Invertir();
                    Console.WriteLine("La lista ha sido invertida.");
                    break;
                case 4:
                    Console.WriteLine("Elementos en la lista:");
                    lista.Mostrar();
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine(); // Línea en blanco para mejor legibilidad
        } while (opcion != 5);
    }
}