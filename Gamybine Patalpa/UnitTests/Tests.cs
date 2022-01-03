using Library.Repositories;
using NUnit.Framework;
using System;

namespace UnitTests
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
            int expectedValue = 50;
            var ivykisRepository = new IvykisRepository(expectedValue);
            int actualValue = ivykisRepository.GautiIvykius().Count;

            Assert.AreEqual(expectedValue, actualValue);
        }
        public void Test2()
        {
            var ivykisRepository = new IvykisRepository(20);
            TimeSpan expectedValue = new TimeSpan(00, 15, 00);
            TimeSpan actualValue = ivykisRepository.GautiLaika("Parukyti");
            Assert.AreEqual(expectedValue, actualValue);
        }
        public void Test3()
        {
            var zmogusRepository = new ZmogusRepository();
            string expectedValue = "Aria";
            var zmogus = zmogusRepository.GautiZmogu(6);
            string actualValue = zmogus.Vardas;
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}