using System;

namespace CreationalDesignPatterns.AbstractFactory
{
    internal class AbstractFactoryClient
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing clients code with first Factory type.");
            ClientMethod(new ConcreteFactory1());

            Console.WriteLine("Client: Testing clients code with second Factory type.");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory abstractFactory)
        {
            var productA = abstractFactory.CreateProductA();
            var productB = abstractFactory.CreateProductB();

            Console.WriteLine(productA.SomeOperationA());
            Console.WriteLine(productB.AnotherUsefulOperationB(productA));
        }
    }
}