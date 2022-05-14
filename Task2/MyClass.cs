using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;

namespace Task2
{
    public class MyClass
    {
        [XmlArray("Listtt")]
        [XmlArrayItem("item")]
        public List<int> List { get; set; }
        public MyClass(string property1, Point point)
        {
            Property1 = property1;
            this.point = point;
            List = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                List.Add(i);
            }
        }
        public MyClass() { }

        [XmlAttribute("Property")]
        public string Property1 { get; set; }

        public Point point { get; set; }

        public void Print()
        {
            Console.WriteLine($"List: { string.Join(' ', List.ToArray())} ");
            Console.WriteLine($"Property1: {Property1}");
            Console.WriteLine($"Point: {point}");
        }
    }
}
