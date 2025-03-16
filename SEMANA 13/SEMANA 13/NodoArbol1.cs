// Clase que representa un nodo individual en el árbol binario de búsqueda
public class NodoArbol
{
    public string NombreRevista;      // Almacena el título de la revista
    public NodoArbol HijoIzquierdo;   // Referencia al hijo izquierdo (menor alfabéticamente)
    public NodoArbol HijoDerecho;     // Referencia al hijo derecho (mayor alfabéticamente)

    // Constructor que inicializa un nuevo nodo con un título
    public NodoArbol(string nombreRevista)
    {
        NombreRevista = nombreRevista;
        HijoIzquierdo = null;         // Inicializa el hijo izquierdo como nulo
        HijoDerecho = null;           // Inicializa el hijo derecho como nulo
    }
}
