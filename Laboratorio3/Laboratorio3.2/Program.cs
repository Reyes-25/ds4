internal class Program
{
    private static void Main(string[] args)
    {
        
        // Operación (a + b) * (a - b)
        Console.Write("Ingresa el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultadoOperacion = CalculosMatematicos.Calcular(numero1, numero2);
        Console.WriteLine($"El resultado de la operación (a + b) * (a - b) es: {resultadoOperacion}\n");

        // Cálculo del área de un círculo
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double areaCirculo = CalculosMatematicos.CalcularArea(radio);
        Console.WriteLine($"El área del círculo con radio {radio} es: {areaCirculo}");
    }
}

class CalculosMatematicos
{
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }

    public static double CalcularArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}