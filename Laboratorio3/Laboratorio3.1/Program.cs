internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Uso de la clase CalculosMatematicos para realizar la operación
        double resultado = CalculosMatematicos.Calcular(numero1, numero2);

        Console.WriteLine($"El resultado de la operación (a + b) * (a - b) es: {resultado}");
    }
}

class CalculosMatematicos
{
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }
}
