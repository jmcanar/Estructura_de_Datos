//Escribir un programa que almacene en una lista los números del 1 al 10 y 
//los muestre por pantalla en orden inverso separados por comas.
public class Ejercicio5
{
    public static void Run()
    {
        // Crear una lista para almacenar los números del 1 al 10
        List<int> numeros = new List<int>();

        // Llenar la lista con los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Mostrar los números en orden inverso, separados por comas
        Console.WriteLine("Números del 1 al 10 en orden inverso:");
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            // Imprimir el número y verificar si no es el último para agregar la coma
            Console.Write(numeros[i]);
            if (i > 0)
            {
                Console.Write(", ");
            }
        }

    }
}