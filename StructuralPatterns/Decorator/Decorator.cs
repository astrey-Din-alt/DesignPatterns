namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Base Decorator class follows the same interface, as other components.
    /// The main goal of this class - determine wrapper interface for concrete components.
    /// Realisation of wrapper code maight include field for storage wrapper component and tool its implementation.

    /// Базовый класс Декоратора следует тому же интерфейсу, что и другие
    /// компоненты. Основная цель этого класса - определить интерфейс обёртки для
    /// всех конкретных декораторов. Реализация кода обёртки по умолчанию может
    /// включать в себя  поле для хранения завёрнутого компонента и средства его
    /// инициализации.
    /// </summary>

    public class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }
        /// <summary>
        /// Декоратор делегирует всю работу обёрнутому компоненту.
        /// </summary>
        /// <returns></returns>
        public override string Operation()
        {
            return (_component != null) ? _component.Operation() : string.Empty;
        }
    }
}