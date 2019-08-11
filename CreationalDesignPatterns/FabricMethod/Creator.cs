namespace CreationalDesignPatterns.FabricMethod
{
    internal abstract class Creator
    {

        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return $"Creator: The same creator's code has just worked with {product.Operation()}";
        }
    }
}