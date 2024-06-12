using BasicOOP_Abstract;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Sound();
        dog.Run();

        Cat cat = new Cat(); ;
        cat.Sound();
        cat.Run();
    }
}