using Attribute_Logging;

class Program
{
    static void Main()
    {
        ExampleService sampleService = new ExampleService();

        Logger.LogMethods(sampleService);
    }
}
