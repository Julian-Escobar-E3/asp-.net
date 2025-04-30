public class Menu
{
    public void Mostrar()
    {
        Console.WriteLine("Mi Calculadora");
        Console.WriteLine("Ingresa el primer número : ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número : ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("/nSeleccione una opción");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("Opción: ");
        string opcion = Console.ReadLine()!;

        try
        {
            double resultado = opcion switch
            {
                "1" => new Suma().Calcular(num1, num2),
                "2" => new Restar().Calcular(num1, num2),
                "3" => new Multiplicacion().Calcular(num1, num2),
                "4" => new Division().Calcular(num1, num2),
                _ => throw new InvalidOperationException("Operación no válida.")
            };
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error " + ex.Message);
        }
    }
}