namespace CreationalDesignPatterns.FabricMethod
{
    internal class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}