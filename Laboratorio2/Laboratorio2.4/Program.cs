using System;

class MyClass2
{
    // Propiedades de la clase MyClass
    public string nombre { get; set; }
    public int Edad { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación del primer objeto de tipo MyClass
        MyClass2 object1 = new MyClass2();
        object1.nombre = "Amir";
        object1.Edad = 33;

        // Asignación de la referencia de object1 a object2
        MyClass2 object2 = object1;
        object2.nombre = "Teo";

        // Imprimir los valores de Nombre desde ambos objetos
        Console.WriteLine(object2.nombre);  // Imprimirá "Teo"
        Console.WriteLine(object1.nombre);  // También imprimirá "Teo"
    }
}
