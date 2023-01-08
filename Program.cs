namespace Discriminan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers fot our funtion!!!");
            Console.WriteLine();

            
            int a;
            do
            {
                Console.Write("a = ");
            }
            while (!int.TryParse(Console.ReadLine(), out a));

            int b;
            do
            {
                Console.Write("b = ");
            }
            while (!int.TryParse(Console.ReadLine(), out b));

            int c;
            do
            {
                Console.Write("c = ");
            }
            while (!int.TryParse(Console.ReadLine(), out c));

            Console.WriteLine();
            Console.WriteLine("This is our function");
            Function.show(a, b, c);
            Console.WriteLine();

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("x can be every number.");
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine($"There ia no solution because {c} is not equal to 0!");
            }
            else if (a == 0)
            {
                Console.WriteLine("If a = 0 we have one solution!");
                Console.WriteLine("x = " + (-c / b));
            } 
            else if (c == 0)
            {
                Console.WriteLine("If c = 0 we have two solutions!");
                Console.WriteLine("x1 = 0");
                Console.WriteLine("x2 = " + (-b / a));
            }
            else if (b == 0)
            {
                Console.WriteLine("If b = 0 we have two solutions!");

                if ((c > 0 && a > 0) || (c < 0 && a < 0))
                {
                    complexNumber temp1 = new complexNumber(0, Math.Sqrt(c / a));
                    complexNumber temp2 = new complexNumber(0, -Math.Sqrt(c / a));
                    Console.WriteLine("x1 = " + temp1);
                    Console.WriteLine("x2 = " + temp2);
                }
                else
                {
                    Console.WriteLine("x1 = " + (Math.Sqrt(-c / a)));
                    Console.WriteLine("x2 = " + (-Math.Sqrt(-c / a)));
                }
            }
            else
            {
                Console.WriteLine("We have two solutions!");
                Console.WriteLine();
                double d = Function.D(a, b, c);
                Console.WriteLine($"Discriminant is equal to {d}");
                complexNumber temp1 = Function.solution1(a, b, d);
                complexNumber temp2 = Function.solution2(a, b, d);
                Console.WriteLine();
                Console.WriteLine("x1 = " + temp1);
                Console.WriteLine("x2 = " + temp2);
            }
        }
    }
}