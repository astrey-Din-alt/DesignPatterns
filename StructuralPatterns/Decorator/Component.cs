namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Base interface of Component introduce behavior, which changes by decorators.
    
    /// Базовый интерфейс Компонента определяет поведение, которое изменяется декораторами
    /// </summary>
    public abstract class Component
    {
        public abstract string Operation();
    }
}