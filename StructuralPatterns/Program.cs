using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ///Adapter pattern example
            //var adapter = new AdapterClient();
            //adapter.Main();

            ///Bridge pattern example
            //var bridgeClient = new BridgeClient();
            //Abstraction abstraction = new Abstraction(new ConcreteImplementationA());
            //bridgeClient.ClientCode(abstraction);
            //Console.WriteLine();
            //abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            //bridgeClient.ClientCode(abstraction);

            ///Composite pattern example
            //CompositeClient client = new CompositeClient();
            //Leaf leaf = new Leaf();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(leaf);
            //var tree = new Composite.Composite();
            //Composite.Composite branch1 = new Composite.Composite();
            //branch1.Add(new Leaf());
            //branch1.Add(new Leaf());
            //Composite.Composite branch2 = new Composite.Composite();
            //branch2.Add(new Leaf());
            //tree.Add(branch1);
            //tree.Add(branch2);
            //Console.WriteLine("Client: Now I've got a composite tree:");
            //client.ClientCode(tree);
            //Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            //client.ClientCode2(tree, leaf);

            /// Decorator pattern example
            //DecoratorClient client = new DecoratorClient();
            //var simple = new ConcreteComponent();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(simple);
            //Console.WriteLine();
            //ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            //ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            //Console.WriteLine("Client: Now I've got a decorated component:");
            //client.ClientCode(decorator2);

            Console.ReadKey();
        }
    }
}