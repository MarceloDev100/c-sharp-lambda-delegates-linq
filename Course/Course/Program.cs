using Course.Services;

namespace Course
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // Delegates
            // - Reference type to one or more methods.
            // - Methods signature must match with delegate.

            BinaryNumericOperation op1 = CalculationService.Sum;
            double result1 = op1(a, b);

            // Alternative sintax
            BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Sum);
            double result2 = op2(a, b);

            double result3 = op2.Invoke(a, b);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}