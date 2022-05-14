using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTestClass myTest = new MyTestClass();
            myTest.Print();
            Console.WriteLine("Сериализация - Десериализация");

            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream("MyTestClass.xml", FileMode.Create);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyTestClass));
                xmlSerializer.Serialize(fileStream, myTest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fileStream?.Close();
            }

            try
            {
                fileStream = new FileStream("MyTestClass.xml", FileMode.Open);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyTestClass));
                ((MyTestClass)xmlSerializer.Deserialize(fileStream)).Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fileStream?.Close();
            }
        }
    }
}
