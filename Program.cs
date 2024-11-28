using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar ingreso de coordenadas
        Console.Write("Ingresa la coordenada X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la coordenada Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Determinar el cuadrante
        if (x > 0 && y > 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Primer Cuadrante.", x, y);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Segundo Cuadrante.", x, y);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Tercer Cuadrante.", x, y);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Cuarto Cuadrante.", x, y);
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está sobre el eje Y.", x, y);
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está sobre el eje X.", x, y);
        }
        else
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el origen.", x, y);
        }

        // Pausa antes de cerrar
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}