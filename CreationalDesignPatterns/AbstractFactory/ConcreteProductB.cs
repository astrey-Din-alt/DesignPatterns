namespace CreationalDesignPatterns.AbstractFactory
{
    internal class ConcreteProductB : IAbstractProductB
    {
        public string AnotherUsefulOperationB(IAbstractProductA collaborator)
        {
            var result = collaborator.SomeOperationA();
            return $"The result of the B1 collaborating with the ({result})";
        }

        public string SomeOperationB()
        {
            return "This is operation of Product B";
        }
    }
}