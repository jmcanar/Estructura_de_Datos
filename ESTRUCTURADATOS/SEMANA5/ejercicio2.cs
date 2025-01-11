//Escribir un programa que pregunte al usuario los números ganadores de la lotería primitiva, 
//los almacene en una lista y los muestre por pantalla ordenados de menor a mayor.
public class Ejercicio4
{
    public static void Run()  
    {  
        // Lista para almacenar los números ganadores  
        List<int> numerosGanadores = new List<int>();  
        int cantidad;  

        // Preguntar al usuario cuántos números quiere ingresar  
        Console.WriteLine("¿Cuántos números ganadores desea ingresar?");  
        cantidad = int.Parse(Console.ReadLine());  

        // Leer los números ganadores  
        for (int i = 0; i < cantidad; i++)  
        {  
            Console.Write($"Ingrese el número ganador {i + 1}: ");  
            int numero = int.Parse(Console.ReadLine());  
            numerosGanadores.Add(numero);  
        }  

        // Ordenar la lista de números ganadores  
        numerosGanadores.Sort();  

        // Mostrar los números ganadores ordenados  
        Console.WriteLine("Números ganadores ordenados de menor a mayor:");  
        foreach (int numero in numerosGanadores)  
        {  
            Console.Write(numero + " ");  
        }  
    }  
}