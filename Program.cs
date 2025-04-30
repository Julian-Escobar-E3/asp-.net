class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mi Calculadora");

        var menu = new Menu();
        menu.Mostrar();

        Console.WriteLine("Presione cualquer tecla para salir...");
        Console.ReadKey();

    }
}