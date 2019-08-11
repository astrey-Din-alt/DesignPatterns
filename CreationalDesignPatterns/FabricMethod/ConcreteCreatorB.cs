namespace CreationalDesignPatterns.FabricMethod
{
    internal class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}