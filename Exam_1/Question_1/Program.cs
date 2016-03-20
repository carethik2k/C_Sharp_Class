using System;

namespace Question_1
{
    class Demo
    {
        public Demo()
        {
            _testVar = 120;
        }

        public Demo(int testValue)
        {
            _testVar = testValue;
        }

        private int _testVar;

        public int TestVar
        {
            get { return _testVar; }
            set { _testVar = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo objDemo = new Demo();
            Console.WriteLine(objDemo.TestVar);
        }
    }
}
