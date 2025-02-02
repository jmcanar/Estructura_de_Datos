// Clase principal del programa
class Program
{
    // Método principal (punto de entrada del programa)
    static void Main(string[] args)
    {
        // Muestra la cabecera del programA
        Console.WriteLine("------UNIVERSIDAD ESTATAL AMAZONICA------");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("---------------PRACTICA#2----------------");
        Console.WriteLine("--------------INTEGRANTES----------------");
        Console.WriteLine("--------JOSE MARCELO CAÑAR JUNCAL--------");   
        Console.WriteLine("--------JHONNY EDITH CONDE PAUCAR--------");     
        Console.WriteLine("-Simulación de un boton de Navegador Web-");
        Console.WriteLine("-----------------------------------------");
        // Crea una instancia del navegador web
        NavegadorWeb navegador = new NavegadorWeb();
        // Simulación de navegación: visita tres páginas
        navegador.VisitarPagina("https://www.google.com");
        navegador.VisitarPagina("https://www.wikipedia.org");
        navegador.VisitarPagina("https://www.github.com");
        Console.WriteLine("-----------------------------------------");
        // Muestra el historial de navegación actual
        navegador.MostrarHistorial();
        Console.WriteLine("-----------------------------------------");
        // Retrocede a la página anterior
        navegador.Retroceder();
        // Muestra el historial después de retroceder
        navegador.MostrarHistorial();
        Console.WriteLine("-----------------------------------------");
        // Retrocede nuevamente
        navegador.Retroceder();
        // Muestra el historial después del segundo retroceso
        navegador.MostrarHistorial();
        Console.WriteLine("-----------------------------------------");
        // Intenta retroceder cuando no hay más páginas en el historial
        navegador.Retroceder();
        Console.WriteLine("-----------------------------------------");
    }
}