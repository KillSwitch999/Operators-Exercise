namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;
            Console.WriteLine(sum);

        int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            
            //Circle radius exercise-User input required
            Console.WriteLine("Type in a value for a radius of a circle below: ");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with a radius of {radius} is {area}");
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
