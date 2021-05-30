using NUnit.Framework;

namespace GItTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Hello America");
            System.Console.WriteLine("Hello India");
            System.Console.WriteLine("Hello China");

            System.Console.WriteLine("Hello UK");
            System.Console.WriteLine("Hello SA");
        }
    }
}
