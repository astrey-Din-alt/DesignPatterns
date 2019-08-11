namespace CreationalDesignPatterns.AbstractFactory
{
    internal class ConcreteProductA : IAbstractProductA
    {
        public string SomeOperationA()
        {
            return "This is operation of Product A";
        }
    }
}