namespace hello;
using lib;

class Program
{
    static void Main(string[] args)
    {
        var referenced = new HelloWorldObject();
        referenced.HelloWorld();
    }
}
