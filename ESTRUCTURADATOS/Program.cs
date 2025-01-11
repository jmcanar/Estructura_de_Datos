
Console.WriteLine ("-----------------------------");
Console.WriteLine ("UNIVERSIDAD ESTATAL AMAZONICA");
Console.WriteLine ("-----------------------------");
Console.WriteLine ("NOMBRE: JOSE MARCELO CAÑAR JUNCAL");
Console.WriteLine ("-----------------------------");
Console.WriteLine ("ESTRUCTURA DE DATOS");
Console.WriteLine ();
Console.WriteLine ("Selecione el Ejercico ");
Console.WriteLine ("1 ====== Ejercicio1 ");
Console.WriteLine ("2 ====== Ejercicio2 ");
Console.WriteLine ("3 ====== Ejercicio4 ");
Console.WriteLine ("4 ====== Ejercicio5 ");
Console.WriteLine ("5 ====== Ejercicio7 ");
Console.WriteLine ("0 ====== salir ");
Console.WriteLine ();
while (true)  
{  
    string opcion = Console.ReadLine(); // Lee una entrada del usuario  

    switch (opcion) // Selecciona un caso basado en la entrada  
    {  
        case "0":  
            return; // Termina el programa  
        case "1":  
            Ejercicio1.Run(); // Programa que almacene las asignaturas de un curso  
            break; // Sale del switch 
        case "2":  
            Ejercicio2.Run(); // programa que almacene las asignaturas de un curso y la muestre por pantalla el mensaje Yo estudio 
            break; // Sale del switch 
        case "3":  
            Ejercicio4.Run(); // programa que pregunte al usuario los números ganadores de la lotería primitiva 
            break; // Sale del switch 
        case "4":  
            Ejercicio5.Run(); // programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.  
            break; // Sale del switch 
        case "5":  
            Ejercicio7.Run(); // Programa que almacene el abecedario en una lista 
            break; // Sale del switch 
        default:  
            Console.WriteLine ("opcion no valida");
            // Puedes añadir un mensaje para opciones no válidas aquí  
            break;  
    }  
}  
;
