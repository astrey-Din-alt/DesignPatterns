namespace CreationalDesignPatterns.AbstractFactory
{
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }
    }
}