using System;

namespace CreationalDesignPatterns.Prototipe
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;
        
        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.Number);
            clone.Name = string.Copy(Name);
            return clone;
        }
    }
}