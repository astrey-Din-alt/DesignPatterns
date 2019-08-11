namespace CreationalDesignPatterns.AbstractFactory
{
    internal class ConcreteFactory2 : IAbstractFactory
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