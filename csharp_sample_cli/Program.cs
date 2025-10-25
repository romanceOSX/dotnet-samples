
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
        }
    }
}

