using CreationalDesignPatterns.Prototipe;
using System;

namespace CreationalDesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ///Fabric Method Example
            //var fabricMethodClient = new FabricMethodClient();
            //fabricMethodClient.Main();

            ///Abstract Fabric Example
            //var abstarctFactoryClient = new AbstractFactoryClient();
            //abstarctFactoryClient.Main();

            ///Builder pattern example
            //var builderClient = new BuilderClient();
            //builderClient.Main();

            ///Prototype pattern example
            var prototipeClient = new ProtorypeClient();
            prototipeClient.Main();
            Console.ReadKey();
        }
    }
}