// Clase que representa la biblioteca 
public class Biblioteca  
{  
    // Diccionario para almacenar los libros (clave: identificador o ISBN, valor: objeto Libro)  
    private Dictionary<string, Libro> DiccionarioLibros { get; set; } = new Dictionary<string, Libro>();  

    // Conjunto para almacenar los libros que están actualmente prestados  
    private HashSet<Libro> LibrosPrestados { get; set; } = new HashSet<Libro>();  

    // Método para agregar un nuevo libro a la biblioteca  
    public void AgregarLibro(Libro libro)  
    {  
        // Verifica si ya existe un libro con el mismo ISBN  
        if (!DiccionarioLibros.ContainsKey(libro.Identificador))  
        {  
            // Agrega el libro al diccionario  
            DiccionarioLibros.Add(libro.Identificador, libro);  
            Console.WriteLine($"Libro '{libro.Titulo}' agregado correctamente.");  
        }  
        else  
        {  
            Console.WriteLine($"Error: Ya existe un libro con el identificador '{libro.Identificador}'.");  
        }  
    }  
    // Método para prestar un libro  
    public void PrestarLibro(string isbn)  
    {  
        // Verifica si el libro existe en la biblioteca  
        if (DiccionarioLibros.ContainsKey(isbn))  
        {  
            Libro libro = DiccionarioLibros[isbn];  
            // Verifica si el libro está disponible  
            if (libro.Disponible)  
            {  
                // Marca el libro como no disponible  
                libro.Disponible = false;  
                // Agrega el libro al conjunto de libros prestados  
                LibrosPrestados.Add(libro);  
                Console.WriteLine($"Libro '{libro.Titulo}' prestado correctamente.");  
            }  
            else  
            {  
                Console.WriteLine($"Error: El libro '{libro.Titulo}' no está disponible para préstamo.");  
            }  
        }  
        else  
        {  
            Console.WriteLine($"Error: No se encontró ningún libro con el identificador '{isbn}'.");  
        }  
    }  
    // Método para devolver un libro  
    public void DevolverLibro(string isbn)  
    {  
        // Verifica si el libro existe en la biblioteca  
        if (DiccionarioLibros.ContainsKey(isbn))  
        {  
            Libro libro = DiccionarioLibros[isbn];  
            // Verifica si el libro no está disponible (está prestado)  
            if (!libro.Disponible)  
            {  
                // Marca el libro como disponible  
                libro.Disponible = true;  
                // Remueve el libro del conjunto de libros prestados  
                LibrosPrestados.Remove(libro);  
                Console.WriteLine($"Libro '{libro.Titulo}' devuelto correctamente.");  
            }  
            else  
            {  
                Console.WriteLine($"Error: El libro '{libro.Titulo}' ya está disponible.");  
            }  
        }  
        else  
        {  
            Console.WriteLine($"Error: No se encontró ningún libro con el identificador '{isbn}'.");  
        }  
    }  
    // Método para buscar un libro por ISBN  
    public Libro BuscarLibroPorISBN(string isbn)  
    {  
        // Verifica si el libro existe en la biblioteca  
        if (DiccionarioLibros.ContainsKey(isbn))  
        {  
            // Retorna el libro encontrado  
            return DiccionarioLibros[isbn];  
        }  
        else  
        {  
            Console.WriteLine($"No se encontró ningún libro con el identificador '{isbn}'.");  
            return null;  
        }  
    }  
    // Método para mostrar la lista de libros prestados  
    public void MostrarLibrosPrestados()  
    {  
        // Verifica si hay libros prestados  
        if (LibrosPrestados.Count > 0)  
        {  
            Console.WriteLine("Libros actualmente prestados:");  
            // Itera sobre el conjunto de libros prestados  
            foreach (Libro libro in LibrosPrestados)  
            {  
                Console.WriteLine(libro); // Imprime la información del libro (gracias al método ToString())  
            }  
        }  
        else  
        {  
            Console.WriteLine("No hay libros prestados actualmente.");  
        }  
    }  
} 