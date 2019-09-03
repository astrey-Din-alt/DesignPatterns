using System.Text;

namespace DesignPatterns.Facade
{
    public class Facade
    {
        protected SubSystem1 _subSystem1;

        protected SubSystem2 _subSystem2;

        public Facade(SubSystem1 subSystem1, SubSystem2 subSystem2)
        {
            _subSystem1 = subSystem1;
            _subSystem2 = subSystem2;
        }

        public string Operation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Facade initializes subsystems:");
            stringBuilder.AppendLine(_subSystem1.Operation1());
            stringBuilder.AppendLine(_subSystem2.Operation1());
            stringBuilder.AppendLine("Facade orders subsystems to perform the action:");
            stringBuilder.AppendLine(_subSystem1.Operation2());
            stringBuilder.AppendLine(_subSystem2.Operation2());
            return stringBuilder.ToString();
        }
    }
}