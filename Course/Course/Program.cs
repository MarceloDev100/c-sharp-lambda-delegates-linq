using Course.Services;

namespace Course
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // Multicast delegates
            // - Hold references to more than one method.
            // - (+=) Operator is used.
            // - Invoke operation or simplified call executes all methods in a predefined order.
            // - It makes more sense for void methods.

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);
            op.Invoke(a, b);
        }
    }
}