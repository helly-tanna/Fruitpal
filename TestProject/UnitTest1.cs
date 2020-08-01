using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestValid()
        {
            
            Console.WriteLine("Testing valid inputs");
            
            Assert.Pass("Success");
        }
        [Test]
        public void TestMethod()
        {


        }

       
    }
}