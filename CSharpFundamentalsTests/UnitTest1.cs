using NUnit.Framework;
using CSharpFundamentals;

namespace CSharpFundamentalsTests
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
            Assert.Pass();
        }

        [Test]
        public void GetPersonTest()
        {
            string fName = "Joe";
            string lName = "Mac";
            string phone = "888-888-8888";
            Person testPerson = new Person();
            testPerson.GetPerson(fName, lName, phone);

            Assert.AreEqual(fName, "Joe");
            Assert.AreEqual(lName, "Mac");
            Assert.AreEqual(phone, "888-888-8888");
        }
    }
}