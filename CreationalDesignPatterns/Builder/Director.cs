namespace CreationalDesignPatterns.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public IBuilder Builder { set => _builder = value; }

        public void BuildSimpleProduct()
        {
            _builder.BuildPartA();
        }

        public void BuildComplicatedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}