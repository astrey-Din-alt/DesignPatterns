using System;

namespace DesignPatterns.Facade
{
    public static class FacadeClient
    {
        public static void ClientCode(Facade fasade)
        {
            Console.WriteLine(fasade.Operation());
        }
    }
}