using System.Collections.Generic;

namespace CreationalDesignPatterns.Builder
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string PartList()
        {
            string str = string.Empty;
            for (int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Product parts: " + str + "\n";
        }
    }
}