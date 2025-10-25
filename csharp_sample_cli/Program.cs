
namespace HelloWorld
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            var names = new [] {"Abc", "SomeD", "SomeC"};
            foreach (var name in names) {
                Console.WriteLine($"Hello {name}");
            }

            //
            // strings
            //

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
        }
    }   
}

