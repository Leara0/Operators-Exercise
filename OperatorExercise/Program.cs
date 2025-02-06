using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.Clear();
            Console.WriteLine("You are an awesome person and have a preoccupation with the numbers 17 and 4. ");
            Console.WriteLine("Let's check out some SUPER interesting relationships between these two numbers!");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();

            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"The sum of {a} plus {b} is {sum}");
            Console.WriteLine($"The difference between {a} and {b} is {difference}");
            Console.WriteLine($"The product of {a} and {b} is {product}");
            Console.WriteLine($"The quotient of {a} divided by {b} is {quotient} with a remainder of {remainder}");

            UraryOperators(a, b);

            Console.WriteLine("\nThat sure was exciting, wasn't it!! Let's keep going!");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();

            RelationalOperators(a, b);

            LogicalOperators(a, b);

            Console.WriteLine("Rivoting stuff, right?? Let's not stop here!");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();

            AssignmentOperator(a, b);

            TernaryOperator(a, b);

            NullCoalescingOperator(a, b);

            Console.WriteLine("Sooooo much fun with 17 and 4!!");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();



            Console.WriteLine($"\nLet's get a little more complicated!");
            Console.WriteLine($"The area of a circle with radius {a} is {AreaOfCircle((double)a):N2}.");
            Console.WriteLine($"The area of a circle with a raduis of {b} is {AreaOfCircle((double)b):N2}.");
            Console.WriteLine("\nWait... what????? You're tired of 17 and 4????? I thought this day would never come!");
            Console.WriteLine("But there's NO WAY I'm going through all those operators again. Let's ");
            Console.WriteLine("just do the circle with your NEW favorite number. Please tell me your new favorite number");
            Console.WriteLine("when you're ready.");

            double radius;
            bool validResponse = false;
            do
            {
                validResponse = double.TryParse(Console.ReadLine(), out radius);
                if (validResponse)
                    validResponse = true;
                else
                    Console.WriteLine("Please enter a valid number");
            } while (!validResponse);
            Console.WriteLine($"The area for a circle with radius {radius} (the new COOL number) is {AreaOfCircle(radius):N2}");



        }
        public static void UraryOperators(int a, int b)
        {
            Console.WriteLine("\nUnary Operators:");
            Console.WriteLine($"{a} incremented is {++a}");
            a--;
            Console.WriteLine($"{b} decremented is {--b}");
            b++;
        }
        public static void RelationalOperators(int a, int b)
        {
            Console.WriteLine("\n Relational Operators:");
            Console.WriteLine($"{a} == {b} is {a == b} (this mean it is false that 17 is equal to 4)");
            Console.WriteLine($"{a} != {b} is {a != b} (this means it is true that {a} is not equal to 4)");
            Console.WriteLine($"{a} > {b} is {a > b} (it is true that 17 is greater than 4)");
            Console.WriteLine($"{a} < {b} is {a < b} (it is false that 17 is less than 4)");
            Console.WriteLine($"{a} >= {b} is {a > b} (it is true that 17 is greater than or equal to 4)");
            Console.WriteLine($"{a} <= {b} is {a < b} (it is false that 17 is less than or equal to 4)");
        }

        public static void LogicalOperators(int a, int b)
        {
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"({a} > {b} && {b} < {a}) is {a > b && b < a} (it is true that 17 is greater than 4 and 4 is less than 17)");
            Console.WriteLine($"({a} > {b} && {b} > {a}) is {a > b || b > a} (it is true that 17 is greater than 4 or 4 is less than 17)");
            Console.WriteLine($"!({a} > {b}) is {!(a > b)} (it is false that it is not true that 17 is greater than 4)");
        }

        public static void AssignmentOperator(int a, int b)
        {
            Console.WriteLine("\nAssignment Operators:");
            Console.WriteLine($"The first number after {b} += 5 is {b += 5}");
            Console.WriteLine($"The first number after {b} -= 5 is {b -= 5}");
            Console.WriteLine($"The first number after {a} *= 8 is {a *= 8}");
            Console.WriteLine($"The first number after {a} /= 8 is {a /= 8}");
            Console.WriteLine($"The first number after {a} %= 8 is {a %= 8}");
            a = 17;
        }
        public static void TernaryOperator(int a, int b)
        {
            Console.WriteLine("\nTernary Operators:");
            Console.WriteLine($"{a} is {(a % 2 == 0 ? "even" : "odd")}");
            Console.WriteLine($"{b} is {(b % 2 == 0 ? "even" : "odd")}");
        }
        public static void NullCoalescingOperator(int a, int b)
        {
            int? x = null;
            int testNull = x ?? a;
            Console.WriteLine("\nNull Coalescing Operator:");
            Console.WriteLine($"testNullOperator is {testNull} when the null coalescing operator must");
            Console.WriteLine("choose between 17 and null.");
            x = b;
            testNull = x ?? a;
            Console.WriteLine($"testNullOperator is {testNull} when the null coalescing operator must");
            Console.WriteLine("choose between 4 and 17 (when 4 is the first option).");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }





    }
}
