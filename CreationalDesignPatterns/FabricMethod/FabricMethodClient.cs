using System;

namespace CreationalDesignPatterns.FabricMethod
{
    internal class FabricMethodClient
    {
        public void Main()
        {
            Console.WriteLine("Launch ConcreteCreatorA");
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine("Launch ConcreteCreatorB");
            ClientCode(new ConcreteCreatorB());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
        }
    }
}