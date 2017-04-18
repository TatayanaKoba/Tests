using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace _1project
{
    internal class Class1
    {

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void OneTest()
        {
            Console.WriteLine("Hi!");
        }

        [TearDown]
        public void TearDown()
        {

        }

    }
}
