
// Clase principal del programa  
public class Program  
{  
    // Método Main (punto de entrada del programa)  
    public static void Main(string[] args)  
    {  
        System.Console.WriteLine("************************************************************************");
        System.Console.WriteLine("*******************UNIVERSIDAD ESTATAL AMAZONICA************************");
        System.Console.WriteLine("***********************PRACTICA EXPERIMENTAL #3*************************");
        System.Console.WriteLine("*****************************INTEGRANTES:*******************************");
        System.Console.WriteLine("***********************JOSE MARCELO CAÑAR JUNCAL************************");
        System.Console.WriteLine("***********************JHONNY EDITH CONDE PAUCAR************************");
        System.Console.WriteLine("");
        // Crea una instancia de la clase Biblioteca  
        Biblioteca biblioteca = new Biblioteca();  
        // Agrega algunos libros a la biblioteca  
        biblioteca.AgregarLibro(new Libro("01", "Ecuador en corto", "Carlos Ferrer", "Relatos"));  
        biblioteca.AgregarLibro(new Libro("02", "Cien Anos De Soledad", "Gabriel Garcia Marquez", "Romance"));  
        biblioteca.AgregarLibro(new Libro("03", "Z el Retrato de Dorian Grey", "Oscar Wilde", "bibliografico"));  
        // Presta un libro  
        biblioteca.PrestarLibro("01");  
        // Muestra los libros prestados  
        biblioteca.MostrarLibrosPrestados();  
        // Devuelve el libro prestado  
        biblioteca.DevolverLibro("01");  
        // Muestra los libros prestados después de la devolución  
        biblioteca.MostrarLibrosPrestados();  
        // Busca un libro por ISBN (identificador) 
        Libro libroEncontrado = biblioteca.BuscarLibroPorISBN("01");  
        if (libroEncontrado != null)  
        {  
            Console.WriteLine($"Libro encontrado: {libroEncontrado}");  
        }  
    }  
}  