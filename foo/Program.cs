
namespace  MyApp;

delegate void MyDelegate(int a, int b);

class Application {
    public static void Foo1(int a, int b) {
        Console.WriteLine($"Calling from Foo1 {a}, {b}");
    }
    public static void Foo2(int a, int b) {
        Console.WriteLine($"Calling from Foo2 {a}, {b}");
    }

    public static void testDelegates() {
        MyDelegate del = new MyDelegate(Foo1);
        del += Foo2;

        del.Invoke(1, 2);
    }

    public static void Main(string[] args) {
        Console.WriteLine("-- Testing Delegates");
        testDelegates();
    }
}

