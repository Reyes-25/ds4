using Laboratorio7._1;

class Program
{
   static void Main(string[] args)
    {
        Banco banco1 = new Banco();
        banco1.Operar();
        banco1.DepositosTotal();
        Console.ReadKey();
    }
}