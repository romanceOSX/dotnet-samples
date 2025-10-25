
namespace HelloWorld
{
    internal class Program {
        //
        // main
        //
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            tutStrings();
            tutNumbers();
            tutTuples();
            tutProgramFlow();
        }

        //
        // strings
        //
        public static void tutStrings() {
            Console.WriteLine("-- Tutorial String");
            // string length
            string sample_name = "Juan";
            Console.WriteLine($"This is the name: {sample_name}, whose length is: {sample_name.Length}");
            
            // trimmings
            sample_name = "     Some other naamee      ";
            Console.WriteLine($"original: [{sample_name}]");
            sample_name = sample_name.TrimEnd();
            Console.WriteLine($"[{sample_name}]");
            sample_name = sample_name.TrimStart();
            Console.WriteLine($"[{sample_name}]");
            sample_name = sample_name.Trim();
            Console.WriteLine($"[{sample_name}]");

            // replace
            var replace_string = "Something to replace to";
            Console.WriteLine(replace_string);
            replace_string = replace_string.Replace("Something", "Goo");
            Console.WriteLine(replace_string);
            
            // to Lower / to Upper
            var to_low_up = "Some Unified String";
            Console.WriteLine(to_low_up.ToLower());
            Console.WriteLine(to_low_up.ToUpper());

            // contains
            var contains_str = "Some containing string foo bar goo";
            Console.WriteLine(contains_str.Contains("goo"));
            Console.WriteLine(contains_str.Contains("Goo"));
        }

        //
        // numbers
        //
        public static void tutNumbers() {
            Console.WriteLine("-- Tutorial Numbers");
            int a = 32;
            Console.WriteLine(a);
            Console.WriteLine($"Max limit of ints: {int.MaxValue}");
            Console.WriteLine($"Min limit of ints: {int.MinValue}");

            Console.WriteLine($"Max limit of ints: {double.MaxValue}");
            Console.WriteLine($"Max limit of ints: {double.MinValue}");
            Console.WriteLine($"sizeof double: {sizeof(double)}");
        }

        // record type
        public record Point(int X, int Y) {
            public double Slope() => (double)Y / (double)X;
        }

        //
        // tuples
        //
        public static void tutTuples() {
            Console.WriteLine("-- Tutorial tuples/types");
            var pt = (X:1.0, Y:3.44);
            var slope = (double)pt.Y / (double)pt.X;
            Console.WriteLine($"The slope of the curve is: {slope}");

            // modified copy
            var pt2 = pt with {X = 4.444};
            Console.WriteLine(pt2);

            // point
            var point = new Point(3, 4);
            var point2 = point with {
                X = 33,
                Y = 33,
            };
            Console.WriteLine($"Original point = \"{point}\", edited point = \"{point2}\"");

            // calling Point record's user-defined method
            Console.WriteLine($"Calling slope on Point {point2.Slope()}");
        }

        //
        // program Flow
        //
        public static void tutProgramFlow() {
            // samo
            Console.WriteLine($"-- Tutorial Program flow");
            for (int counter = 0; counter < 10; ++counter) {
                Console.WriteLine($"This is the counter {counter}");
            }
        }
    }
}

