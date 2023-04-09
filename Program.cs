namespace StaticField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(2);
            TestClass testClass1 = new TestClass(14);
            
            Console.WriteLine(testClass.GetI());//14
            Console.WriteLine(testClass1.GetI());//14
            Console.WriteLine(TestClass.i);//14

            TestClass.i = 30;

            Console.WriteLine(testClass.GetI());//30
            Console.WriteLine(testClass1.GetI());//30
            Console.WriteLine(TestClass.i);//30
        }
    }


    class TestClass
    {
        public static int i = 0;
        public TestClass(int j)
        {
            i = j;
        }
        public int GetI() => i;
    }
}