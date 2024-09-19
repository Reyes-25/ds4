using Laboratorio8._1;

class Program
{
    public static void Main(string[] arg)
    {
        Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
        Console.WriteLine("Nombre = " + p.Nombre);
        Console.WriteLine("Edad = " + p.Edad);
        Console.WriteLine("NIF = " + p.NIF);
        Console.WriteLine("Sueldo = " + p.Sueldo);
        Console.ReadKey();
    }
}