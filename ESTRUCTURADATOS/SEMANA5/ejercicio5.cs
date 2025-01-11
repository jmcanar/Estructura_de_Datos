//Escribir un programa que almacene el abecedario en una lista, 
//elimine de la lista las letras que ocupen posiciones múltiplos de 3,
// y muestre por pantalla la lista resultante.
public class Ejercicio7  
{  
    public static void Run()  
    {  
        // Almacenar el abecedario en una lista  
        List<char> abecedario = new List<char>();  
        for (char c = 'a'; c <= 'z'; c++)  
        {  
            abecedario.Add(c);  
        }  

        // Eliminar letras en posiciones múltiples de 3  
        // Recorrer la lista en orden inverso para evitar problemas al eliminar elementos  
        for (int i = abecedario.Count - 1; i >= 0; i--)  
        {  
            // Las posiciones comienzan desde 1, así que usamos i+1  
            if ((i + 1) % 3 == 0)  
            {  
                abecedario.RemoveAt(i);  
            }  
        }  

        // Mostrar la lista resultante  
        Console.WriteLine("Lista resultante:");  
        foreach (char letra in abecedario)  
        {  
            Console.Write(letra + " ");  
        }  
    }  
}  