using System;

namespace DesignPatterns.Bridge
{
    class BridgeClient
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}