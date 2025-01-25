
class TorresDeHanoi
{
    private Stack<int> torre1;
    private Stack<int> torre2;
    private Stack<int> torre3;

    public TorresDeHanoi()
    {
        // Inicializar torres
        torre1 = new Stack<int>();
        torre2 = new Stack<int>();
        torre3 = new Stack<int>();

        // Colocar 3 discos en la primera torre (de mayor a menor)
        torre1.Push(3);
        torre1.Push(2);
        torre1.Push(1);
    }

    public void ResolverHanoi()
    {
        // Mover 3 discos de torre1 a torre3 usando torre2 como auxiliar
        MoverTorre(3, torre1, torre3, torre2);
    }

    private void MoverTorre(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (n > 0)
        {
            // Mover n-1 discos de origen a auxiliar
            MoverTorre(n - 1, origen, auxiliar, destino);

            // Mover el disco superior de origen a destino
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Se mueve el  disco {disco} de {ObtenerNombreTorre(origen)} a {ObtenerNombreTorre(destino)}");

            // Mover n-1 discos de auxiliar a destino
            MoverTorre(n - 1, auxiliar, destino, origen);
        }
    }

    private string ObtenerNombreTorre(Stack<int> torre)
    {
        if (torre == torre1) return "Torre 1";
        if (torre == torre2) return "Torre 2";
        return "Torre 3";
    }

    public void MostrarEstadoTorres()
    {
       
        Console.WriteLine("Estado de las torres:");
        Console.WriteLine($"Torre 1: {string.Join(", ", torre1)}");
        Console.WriteLine($"Torre 2: {string.Join(", ", torre2)}");
        Console.WriteLine($"Torre 3: {string.Join(", ", torre3)}");
    }

    static void Main()
    {
        TorresDeHanoi juego = new TorresDeHanoi();
        Console.WriteLine("******************************************************");
        Console.WriteLine("            UNIVERSIDAD ESTATAL AMAZONICA             ");
        Console.WriteLine("******************************************************");
        Console.WriteLine("              NOMBRE: JOSE MARCELO CAÑAR              ");
        Console.WriteLine("******************************************************");
        Console.WriteLine("");
        Console.WriteLine("Estado inicial:");
        juego.MostrarEstadoTorres();

        Console.WriteLine("\nResolviendo Torres de Hanoi...");
        juego.ResolverHanoi();

        Console.WriteLine("\nEstado final:");
        juego.MostrarEstadoTorres();
    }
}