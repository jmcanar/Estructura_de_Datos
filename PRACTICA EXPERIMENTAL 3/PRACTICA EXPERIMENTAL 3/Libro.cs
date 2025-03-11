// Clase que representa un libro  
public class Libro  
{  
    // Propiedades del libro  
    public string Identificador { get; set; } // Identificador único del libro (clave)  
    public string Titulo { get; set; } // Título del libro  
    public string Autor { get; set; } // Autor del libro  
    public string Genero { get; set; } // Género del libro  
    public bool Disponible { get; set; } // Indica si el libro está disponible para préstamo  
    // Constructor de la clase Libro  
    public Libro(string isbn, string titulo, string autor, string genero)  
    {  
        Identificador = isbn;  
        Titulo = titulo;  
        Autor = autor;  
        Genero = genero;  
        Disponible = true; // Por defecto, un libro recién registrado está disponible  
    }  
    // Sobreescribe el método ToString() para una representación legible del objeto Libro  
    public override string ToString()  
    {  
        return $"Identificador: {Identificador}, Título: {Titulo}, Autor: {Autor},  Género: {Genero}, Disponible: {(Disponible ? "Sí" : "No")}";  
    }  
}  