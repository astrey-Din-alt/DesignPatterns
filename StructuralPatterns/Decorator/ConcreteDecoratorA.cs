namespace DesignPatterns.Decorator
{
    /// <summary>
    ///  
    /// Concrete Decorators call wrapper object and change its result in some way.
    /// 
    /// Конкретные Декораторы вызывают обёрнутый объект и изменяют его результат некоторым образом.
    /// </summary>

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }
        /// <summary>
        /// Декораторы могут вызывать родительскую реализацию операции, вместо
        /// того, чтобы вызвать обёрнутый объект напрямую. Такой подход упрощает
        /// расширение классов декораторов.
        /// </summary>
        /// <returns></returns>
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}