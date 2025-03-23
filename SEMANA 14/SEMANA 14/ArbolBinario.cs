class ArbolBinario
{
    private Nodo raiz;  // Raíz del árbol binario
    // Constructor del árbol
    public ArbolBinario()
    {
        raiz = null;
    }
    // Método público para insertar un valor
    public void Insertar(int dato)
    {
        raiz = InsertarRecursivo(raiz, dato);
    }
    // Método privado recursivo para insertar
    private Nodo InsertarRecursivo(Nodo nodo, int dato)
    {
        // Si el nodo es nulo, crear uno nuevo
        if (nodo == null)
            return new Nodo(dato);
        // Insertar en subárbol izquierdo si el dato es menor
        if (dato < nodo.Dato)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, dato);
        // Insertar en subárbol derecho si el dato es mayor
        else if (dato > nodo.Dato)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, dato);
        return nodo;
    }
    // Método público para buscar un valor
    public bool Buscar(int dato)
    {
        return BuscarRecursivo(raiz, dato);
    }
    // Método privado recursivo para buscar
    private bool BuscarRecursivo(Nodo nodo, int dato)
    {
        // Si el nodo es nulo, no se encontró el valor
        if (nodo == null)
            return false;
        
        // Si el valor coincide, se encontró
        if (nodo.Dato == dato)
            return true;

        // Buscar en subárbol izquierdo o derecho según el valor
        return dato < nodo.Dato 
            ? BuscarRecursivo(nodo.Izquierdo, dato)
            : BuscarRecursivo(nodo.Derecho, dato);
    }
    // Método público para eliminar un valor
    public void Eliminar(int dato)
    {
        raiz = EliminarRecursivo(raiz, dato);
    }
    // Método privado recursivo para eliminar
    private Nodo EliminarRecursivo(Nodo nodo, int dato)
    {
        // Si el nodo es nulo, no hay nada que eliminar
        if (nodo == null)
            return null;
        // Buscar el nodo a eliminar
        if (dato < nodo.Dato)
            nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, dato);
        else if (dato > nodo.Dato)
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, dato);
        else
        {
            // Caso 1: Nodo sin hijo izquierdo
            if (nodo.Izquierdo == null)
                return nodo.Derecho;
            // Caso 2: Nodo sin hijo derecho
            if (nodo.Derecho == null)
                return nodo.Izquierdo;

            // Caso 3: Nodo con dos hijos
            // Reemplazar con el valor mínimo del subárbol derecho
            nodo.Dato = ValorMinimo(nodo.Derecho);
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, nodo.Dato);
        }
        return nodo;
    }
    // Método auxiliar para encontrar el valor mínimo
    private int ValorMinimo(Nodo nodo)
    {
        // Avanzar hasta el nodo más a la izquierda
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;
        return nodo.Dato;
    }
    // Métodos públicos para los recorridos
    public void MostrarInOrden() => RecorrerInOrden(raiz);
    public void MostrarPreOrden() => RecorrerPreOrden(raiz);
    public void MostrarPostOrden() => RecorrerPostOrden(raiz);
    // Recorrido In-Orden (Izquierdo-Raíz-Derecho)
    private void RecorrerInOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorrerInOrden(nodo.Izquierdo);
            Console.Write($"{nodo.Dato} ");
            RecorrerInOrden(nodo.Derecho);
        }
    }
    // Recorrido Pre-Orden (Raíz-Izquierdo-Derecho)
    private void RecorrerPreOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write($"{nodo.Dato} ");
            RecorrerPreOrden(nodo.Izquierdo);
            RecorrerPreOrden(nodo.Derecho);
        }
    }
    // Recorrido Post-Orden (Izquierdo-Derecho-Raíz)
    private void RecorrerPostOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorrerPostOrden(nodo.Izquierdo);
            RecorrerPostOrden(nodo.Derecho);
            Console.Write($"{nodo.Dato} ");
        }
    }
}