using Laboratorio15._2;

internal class Program
{
    private static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) => 
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(WebBuilder =>
        {
            WebBuilder.UseStartup<Startup>();
        });
}