using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DynamicFizzBuzz.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestItShouldReturnFizzBuzzBazzIfItemCountIs105()
        {
            List<string> list = new List<string>();
            var dynamicFizzBuzz = new DynamicFizzBuzz();
            var dynamicFizzBuzzRequest = new DynamicFizzBuzzRequest()
            {
                MaxNumber = 105,
                Configurations = new Dictionary<int, string> {
                    { 3, "Fizz" },
                    { 5, "Buzz" },
                    { 7, "Bazz" }
                }
            };

            dynamicFizzBuzz.Handle(dynamicFizzBuzzRequest, (result) => { list.Add(result); });
            Assert.AreEqual("FizzBuzzBazz", list.Last());
        }

        [Test]
        public void TestItShouldReturnFizzTriceIfItemCountIs10()
        {
            List<string> list = new List<string>();
            var dynamicFizzBuzz = new DynamicFizzBuzz();
            var dynamicFizzBuzzRequest = new DynamicFizzBuzzRequest()
            {
                MaxNumber = 10,
                Configurations = new Dictionary<int, string> {
                    { 3, "Fizz" },
                    { 5, "Buzz" },
                    { 7, "Bazz" }
                }
            };

            dynamicFizzBuzz.Handle(dynamicFizzBuzzRequest, (result) => { list.Add(result); });
            Assert.AreEqual(3, list.Where(l => l == "Fizz").Count());
        }
    }
}