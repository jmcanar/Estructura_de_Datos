// Clase que gestiona la colección de revistas en un árbol binario
public class BibliotecaRevistas
{
    private NodoArbol raiz;           // Nodo raíz del árbol
// Método público para agregar una nueva revista al catálogo
    public void Agregar(string nombreRevista)
    {
        raiz = AgregarNodo(raiz, nombreRevista);  // Inicia el proceso de inserción desde la raíz
    }

// Método privado recursivo para insertar un nodo en la posición correcta
    private NodoArbol AgregarNodo(NodoArbol nodoActual, string nombreRevista)
    {
        // Si el nodo actual es nulo, hemos encontrado la posición para el nuevo nodo
        if (nodoActual == null)
        {
            return new NodoArbol(nombreRevista);  // Crea y retorna el nuevo nodo
        }

        // Compara alfabéticamente el nuevo título con el título del nodo actual
        int resultadoComparacion = string.Compare(nombreRevista, nodoActual.NombreRevista);
        
        if (resultadoComparacion < 0)    // Si el nuevo título va antes alfabéticamente
        {
            nodoActual.HijoIzquierdo = AgregarNodo(nodoActual.HijoIzquierdo, nombreRevista);
        }
        else if (resultadoComparacion > 0)  // Si el nuevo título va después alfabéticamente
        {
            nodoActual.HijoDerecho = AgregarNodo(nodoActual.HijoDerecho, nombreRevista);
        } // Nota: Si los títulos son iguales (resultadoComparacion == 0), no se inserta (no permite duplicados)
        
        return nodoActual;  // Retorna el nodo actual para mantener la estructura del árbol
    }
 // Método público para verificar si una revista existe en el catálogo
    public bool ExisteRevista(string nombreRevista)
    {
        return BuscarNodo(raiz, nombreRevista);  // Inicia la búsqueda desde la raíz
    }

 // Método privado recursivo para buscar un título en el árbol
    private bool BuscarNodo(NodoArbol nodoActual, string nombreRevista)
    {
        // Si el nodo es nulo, el título no existe en esta rama
        if (nodoActual == null)
        {
            return false;
        }
        // Compara alfabéticamente el título buscado con el título del nodo actual
        int resultadoComparacion = string.Compare(nombreRevista, nodoActual.NombreRevista);
        
        if (resultadoComparacion == 0)  // Si son iguales, encontramos el título
        {
            return true;
        }
        else if (resultadoComparacion < 0)  // Si el título buscado va antes, busca en la izquierda
        {
            return BuscarNodo(nodoActual.HijoIzquierdo, nombreRevista);
        }
        else  // Si el título buscado va después, busca en la derecha
        {
            return BuscarNodo(nodoActual.HijoDerecho, nombreRevista);
        }
    }
}
