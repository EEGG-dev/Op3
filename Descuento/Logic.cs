namespace Descuento;

public static class Logic
{
    public static double PedirValorProducto()
    {
        while (true)
        {
            Console.Write("Ingresa el valor del producto: ");
            if (double.TryParse(Console.ReadLine(), out var valor) && valor >= 0)
                return valor;

            System.Console.WriteLine("Valor invalido. Intente nuevamente.");
        }
    }

    public static double PedirPorcentajeDescuento()
    {
        while (true)
        {
            Console.Write("Ingrese el porcentaje de descuento (0 - 100): ");
            if (double.TryParse(Console.ReadLine(), out double porcentaje) && porcentaje >= 0 && porcentaje <=100)
                return porcentaje;

            System.Console.WriteLine("Porcentaje invalido. Intente nuevamente.");
        }
    }

    public static double CalcularPrecioFinal(double valorProducto, double porcentajeDescuento)
    {
        return valorProducto - (valorProducto * porcentajeDescuento / 100);
    }

    public static void MostrarPrecioFinal(double precioFinal)
    {
        System.Console.WriteLine($"El precio final con descuento es: {precioFinal:C2}");
    }

    public static bool AskToContinue()
    {
        Console.Write("Do you keep going: ");
        string continueLooping = Console.ReadLine();
        System.Console.WriteLine();

        bool output = (continueLooping == "yes");
        return output; 
    }

    public static void MainLogic()
    {
       do
       {
            double valorProducto = PedirValorProducto();
            double porcentajeDescuento = PedirPorcentajeDescuento();
            double precioFinal = CalcularPrecioFinal(valorProducto, porcentajeDescuento);
            MostrarPrecioFinal(precioFinal);
            System.Console.WriteLine();

       } while (AskToContinue());
    }
}
