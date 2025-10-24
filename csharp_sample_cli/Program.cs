
namespace HelloWorld
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            var names = new [] {"Abc", "SomeD", "SomeC"};
            foreach (var name in names) {
                Console.WriteLine($"Hello {name}");
            }
        }
    }   
}

