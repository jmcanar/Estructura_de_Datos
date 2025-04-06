class Programa
{
    static void Main(string[] args)
    {
        // Crear un grafo con 5 aeropuertos
        GrafoVuelos grafo = new GrafoVuelos(5);

        // Agregar vuelos con sus precios entre aeropuertos reales
        grafo.AgregarVuelo(0, 1, 150.00); // Guayaquil → Medellín: $200
        grafo.AgregarVuelo(0, 2, 250.00); // Guayaquil → Bogotá: $250
        grafo.AgregarVuelo(1, 2, 150.00); // Medellín → Bogotá: $150
        grafo.AgregarVuelo(1, 3, 350.00); // Medellín → Lima: $350
        grafo.AgregarVuelo(2, 3, 300.00); // Bogotá → Lima: $300
        grafo.AgregarVuelo(3, 4, 200.00); // Lima → Santiago: $200

        // Calcular y mostrar el vuelo más barato de Guayaquil a Santiago
        grafo.EncontrarVueloMasBarato(0, 4);
    }
}
