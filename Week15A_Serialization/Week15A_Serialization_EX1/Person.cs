using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week15A_Serialization_EX1
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        void IDeserializationCallback.OnDeserialization(Object sender)
        {

        }

        private string name;
        [NonSerialized] private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return name + " " + age;
        }
    }
}
