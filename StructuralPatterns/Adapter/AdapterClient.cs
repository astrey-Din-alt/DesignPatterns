using System;

namespace DesignPatterns.Adapter
{
    public class AdapterClient
    {
        public void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine(target.GetRequest());
        }
    }
}