//Escribir un programa que almacene las asignaturas de un curso
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
//en una lista y la muestre por pantalla el mensaje Yo estudio <asignatura>, 
//donde <asignatura> es cada una de las asignaturas de la lista.
public class Ejercicio2
{
    public static void Run()
    {
        // Crear una lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Mostrar las asignaturas por pantalla
        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("yo estudio:");
            Console.WriteLine(asignatura);
            
        }
    }
}