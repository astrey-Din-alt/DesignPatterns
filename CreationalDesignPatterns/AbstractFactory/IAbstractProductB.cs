namespace CreationalDesignPatterns.AbstractFactory
{
    internal interface IAbstractProductB
    {
        string SomeOperationB();

        string AnotherUsefulOperationB(IAbstractProductA collaborator);
    }
}