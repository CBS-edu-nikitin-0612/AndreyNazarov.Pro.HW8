using System;
using System.IO;
using System.Xml.Serialization;
using Task2;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = File.OpenRead("MyClass.xml");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyClass));

                MyClass myClass = xmlSerializer.Deserialize(fileStream) as MyClass;
                myClass.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fileStream?.Close();
            }
        }
    }
}
