using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("test", new Point(10, 10));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyClass));
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream("MyClass.xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                xmlSerializer.Serialize(fileStream, myClass);
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
