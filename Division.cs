public class Division
{
    public double Calcular(double a, double b)
    {

        if (b == 0) throw new DivideByZeroException("No se puede entre cero.");
        return a / b;
    }
}