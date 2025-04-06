class GrafoVuelos
{
    private int V; // Número total de aeropuertos (vértices)
    private List<(int destino, double precio)>[] ady; // Lista de adyacencia que almacena destinos y precios
    private string[] nombresAeropuertos; // Arreglo para almacenar los nombres de los aeropuertos

    // Constructor que inicializa el grafo con un número dado de aeropuertos
    public GrafoVuelos(int vertices)
    {
        V = vertices;
        ady = new List<(int destino, double precio)>[V];
        nombresAeropuertos = new string[V];
        // Crear una lista vacía para cada aeropuerto
        for (int i = 0; i < V; i++)
            ady[i] = new List<(int destino, double precio)>();

        // Asignar nombres a los aeropuertos
        nombresAeropuertos[0] = "Guayaquil (GYE)";
        nombresAeropuertos[1] = "Medellín (MDE)";
        nombresAeropuertos[2] = "Bogotá (BOG)";
        nombresAeropuertos[3] = "Lima (LIM)";
        nombresAeropuertos[4] = "Santiago (SCL)";
    }

    // Método para agregar un vuelo entre dos aeropuertos con su precio
    public void AgregarVuelo(int origen, int destino, double precio)
    {
        // Añade una tupla (destino, precio) a la lista de adyacencia del origen
        ady[origen].Add((destino, precio));
    }

    // Algoritmo de Dijkstra para encontrar el vuelo más barato entre dos aeropuertos
    public void EncontrarVueloMasBarato(int origen, int destino)
    {
        double[] dist = new double[V]; // Arreglo para almacenar las distancias mínimas
        int[] predecesores = new int[V]; // Arreglo para rastrear la ruta
        bool[] conjuntoProcesado = new bool[V]; // Marca los vértices ya procesados

        // Inicializar distancias y predecesores
        for (int i = 0; i < V; i++)
        {
            dist[i] = double.MaxValue;
            predecesores[i] = -1; // -1 indica sin predecesor
        }

        // La distancia al aeropuerto de origen es 0
        dist[origen] = 0;

        // Procesar todos los vértices menos uno (V-1 iteraciones)
        for (int cuenta = 0; cuenta < V - 1; cuenta++)
        {
            // Encontrar el vértice no procesado con distancia mínima
            int u = DistanciaMinima(dist, conjuntoProcesado);
            conjuntoProcesado[u] = true; // Marcar como procesado

            // Actualizar las distancias de los vértices adyacentes a u
            foreach (var arista in ady[u])
            {
                // Si el destino no está procesado y se encuentra un camino más barato
                if (!conjuntoProcesado[arista.destino] && 
                    dist[u] != double.MaxValue && 
                    dist[u] + arista.precio < dist[arista.destino])
                {
                    // Actualizar la distancia mínima y el predecesor
                    dist[arista.destino] = dist[u] + arista.precio;
                    predecesores[arista.destino] = u;
                }
            }
        }

        // Reconstruir y mostrar la ruta
        List<string> ruta = ConstruirRuta(origen, destino, predecesores);
        System.Console.WriteLine("------UNIVERIDAD ESTATAL AMAZONICA------------");
        System.Console.WriteLine("----------PRACTICA EXPERIMENTAL 4-------------");
        System.Console.WriteLine("-----------------INTEGRANTES------------------");
        System.Console.WriteLine("-----JOSE MARCELO CAÑAR JUNCAL----------------");
        System.Console.WriteLine("-----JHONNY EDITH CONDE PAUCAR----------------");
        Console.WriteLine($"El costo más bajo del vuelo de {nombresAeropuertos[origen]} a {nombresAeropuertos[destino]} es: ${dist[destino]}");
        Console.WriteLine("Ruta de vuelos:");
        foreach (string paso in ruta)
        {
            Console.WriteLine(paso);
        }
    }

    // Método para reconstruir la ruta desde los predecesores
    private List<string> ConstruirRuta(int origen, int destino, int[] predecesores)
    {
        List<int> indicesRuta = new List<int>();
        List<string> ruta = new List<string>();
        int actual = destino;

        // Reconstruir la ruta desde el destino hasta el origen
        while (actual != -1)
        {
            indicesRuta.Add(actual);
            actual = predecesores[actual];
        }
        indicesRuta.Reverse(); // Invertir para mostrar de origen a destino

        // Construir las descripciones de los vuelos
        for (int i = 0; i < indicesRuta.Count - 1; i++)
        {
            int de = indicesRuta[i];
            int a = indicesRuta[i + 1];
            double costo = ady[de].Find(vuelo => vuelo.destino == a).precio;
            ruta.Add($"{nombresAeropuertos[de]} → {nombresAeropuertos[a]}: ${costo}");
        }

        return ruta;
    }

    // Método auxiliar para encontrar el vértice no procesado con distancia mínima
    private int DistanciaMinima(double[] dist, bool[] conjuntoProcesado)
    {
        double min = double.MaxValue; // Valor inicial mínimo
        int indice_min = -1; // Índice del vértice con distancia mínima
        
        // Recorrer todos los vértices
        for (int v = 0; v < V; v++)
        {
            // Si no está procesado y su distancia es menor al mínimo actual
            if (!conjuntoProcesado[v] && dist[v] < min)
            {
                min = dist[v];
                indice_min = v;
            }
        }
        return indice_min; // Devolver el índice del vértice encontrado
    }
}