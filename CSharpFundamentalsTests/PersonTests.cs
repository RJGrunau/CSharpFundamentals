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
            Person testPerson = new Person(fName, lName, phone);
            testPerson.GetPerson();

            Assert.AreEqual(fName, fName);
            Assert.AreEqual(lName, lName);
            Assert.AreEqual(phone, phone);
        }
    }
}