using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Week15A_Serialization_EX1
{
    class Program
    {

        private static void Serialize(Person sp)
        {
            // Create file to save the data to 
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            // Create a BinaryFormatter object to perform the serialization 
            BinaryFormatter bf = new BinaryFormatter();

            // Use the BinaryFormatter object to serialize the data to the file 
            bf.Serialize(fs, sp);

            // Close the file 
            fs.Close();
        }

        private static Person Deserialize()
        {
            Person dsp;

            // Open file to read the data from 
            FileStream fs = new FileStream("Person.Dat", FileMode.Open);

            // Create a BinaryFormatter object to perform the deserialization 
            BinaryFormatter bf = new BinaryFormatter();

            // Use the BinaryFormatter object to deserialize the data from the file 
            dsp = (Person)bf.Deserialize(fs);

            // Close the file 
            fs.Close();

            return dsp;
        }
        static void Main(string[] args)
        {
        }
    }
}
