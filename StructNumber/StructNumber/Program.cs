namespace StructNumber;

internal class Program
{
    static void Main(string[] args)
    {
        DecimalNumber decimalNumber = new DecimalNumber(550);
        decimalNumber.Binary();
        decimalNumber.Octal();
        decimalNumber.Hex();
    }
}
