using System;

namespace DesignPatterns.Decorator
{
    public class DecoratorClient
    {
        /// <summary>
        ///
        /// Clients code works with all objects using Component interface.
        /// This way it stays independent from concrete component classes.
        ///
        /// Клиентский код работает со всеми объектами, используя интерфейс
        /// Компонента. Таким образом, он остаётся независимым от конкретных
        /// классов компонентов, с которыми работает.

        /// </summary>
        /// <param name="component"></param>
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}