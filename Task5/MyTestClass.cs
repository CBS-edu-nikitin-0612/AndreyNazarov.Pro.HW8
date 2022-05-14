using System;
using System.Runtime.Serialization;

namespace Task5
{
    [Serializable]
    public class MyTestClass : ISerializable
    {
        public MyTestClass() { }
        protected MyTestClass(SerializationInfo info, StreamingContext context)
        {
            Test1 = info.GetString("Test1");
            Test2 = info.GetInt32("Test2");
            Test3 = info.GetDouble("Test3");
        }
        public string Test1 { get; set; } = "test";
        public int Test2 { get; set; } = 10;
        public double Test3 { get; set; } = 10;
       
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Test1", Test1);
            info.AddValue("Test2", Test2);
            info.AddValue("Test3", Test3);
        }

        public void Print()
        {
            Console.WriteLine(Test1);
            Console.WriteLine(Test2);
            Console.WriteLine(Test3);
        }

    }
}
