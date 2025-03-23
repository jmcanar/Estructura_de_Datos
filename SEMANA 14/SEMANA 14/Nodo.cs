class Nodo
{
    // Propiedades del nodo
    public int Dato { get; set; }          // Valor almacenado en el nodo
    public Nodo Izquierdo { get; set; }    // Referencia al hijo izquierdo
    public Nodo Derecho { get; set; }      // Referencia al hijo derecho
    // Constructor del nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Izquierdo = null;
        Derecho = null;
    }
}
