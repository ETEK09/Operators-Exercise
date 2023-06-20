namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient}, and the remiander is {remainder}");

            Console.WriteLine("Please enter the radius of your cirlce:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
            Console.WriteLine($"The area of your circle with a radius of {radius} is {AreaOfCircle(radius)} ");
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
