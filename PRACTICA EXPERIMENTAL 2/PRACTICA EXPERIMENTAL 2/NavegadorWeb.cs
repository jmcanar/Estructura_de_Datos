// Clase que representa un navegador web con funcionalidad de retroceso
class NavegadorWeb
{
    // Pila para almacenar el historial de navegación
    private Stack<string> historial;

    // Constructor de la clase NavegadorWeb
    public NavegadorWeb()
    {
        // Inicializa la pila para el historial
        historial = new Stack<string>();
    }

    // Método para visitar una nueva página
    public void VisitarPagina(string url)
    {
        // Muestra un mensaje indicando la página que se está visitando
        Console.WriteLine($"Visitando: {url}");
        // Agrega la URL de la página a la pila del historial
        historial.Push(url);
    }

    // Método para retroceder a la página anterior
    public void Retroceder()
    {
        // Verifica si hay al menos dos páginas en el historial
        if (historial.Count > 1)
        {
            // Elimina la página actual de la pila (la última visitada)
            string paginaActual = historial.Pop();
            // Obtiene la página anterior sin eliminarla de la pila
            string paginaAnterior = historial.Peek();
            // Muestra un mensaje indicando a qué página se está retrocediendo
            Console.WriteLine($"Retrocediendo con el boton a: {paginaAnterior}");
        }
        else
        {
            // Muestra un mensaje si no hay páginas anteriores en el historial
            Console.WriteLine("No hay páginas anteriores en el historial.");
        }
    }

    // Método para mostrar el historial de navegación
    public void MostrarHistorial()
    {
        // Muestra un título para el historial
        Console.WriteLine("Historial de navegación:");
        // Recorre cada página en la pila y la muestra
        foreach (var pagina in historial)
        {
            Console.WriteLine(pagina);
        }
    }
}