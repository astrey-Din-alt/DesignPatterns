namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Concrete Components introduce behavior realizations for default.
    /// It might be several variaties if this class.

    /// Конкретные Компоненты предоставляют реализации поведения по умолчанию.
    /// Может быть несколько вариаций этих классов.
    /// </summary>

    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}