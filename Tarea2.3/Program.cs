using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de artículos comprados: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double precioPorProducto;

        if (cantidad <= 10)
        {
            precioPorProducto = 20;
        }
        else
        {
            precioPorProducto = 15;
        }

        double total = cantidad * precioPorProducto;

        Console.WriteLine($"Precio por producto: ${precioPorProducto}");
        Console.WriteLine($"Total a pagar: ${total}");

        Console.ReadLine(); // Esperar una entrada del usuario antes de cerrar la consola
    }
}
