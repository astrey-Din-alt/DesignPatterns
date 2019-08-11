using System;

namespace CreationalDesignPatterns.Builder
{
    public class BuilderClient
    {
        public void Main()
        {
            ConcreteBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            Console.WriteLine("Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(builder.GetProduct().PartList());

            Console.WriteLine("Standard full featured product:");
            director.BuildComplicatedProduct();
            Console.WriteLine(builder.GetProduct().PartList());

            // With no Director class
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().PartList());
        }
    }
}