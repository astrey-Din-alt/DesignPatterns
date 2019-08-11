namespace CreationalDesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product;

        public ConcreteBuilder()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            _product.Add("PartA1");
        }

        public void BuildPartB()
        {
            _product.Add("PartB1");
        }

        public void BuildPartC()
        {
            _product.Add("PartC1");
        }

        public void Reset()
        {
            _product = new Product();
        }

        public Product GetProduct()
        {
            Product result = _product;
            Reset();
            return result;
        }
    }
}