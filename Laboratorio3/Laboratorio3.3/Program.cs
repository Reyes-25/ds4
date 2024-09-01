internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa la longitud del primer lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la longitud del segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        double perimetro = CalcularPerimetro(lado1, lado2);

        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }

    static double CalcularPerimetro(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
}