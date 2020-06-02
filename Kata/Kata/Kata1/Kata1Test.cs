using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Kata1
{
    [TestFixture]
    public class Kata1Test
    {
        [Test]
        public void Zero_Nine_Five_Two()
        {
            Assert.AreEqual("four", Kata1.AverageString("zero nine five two"));
            Assert.AreEqual("three", Kata1.AverageString("one two three four five"));
            Assert.AreEqual("four", Kata1.AverageString("five four"));
            Assert.AreEqual("zero", Kata1.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata1.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Kata1.AverageString(""));
        }
        [Test]
        public void Four_Six_Two_Three()
        {
            Assert.AreEqual("three", Kata1.AverageString("four six two three"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual("n/a", Kata1.AverageString(""));
        }

        [Test]
        public void NullInput()
        {
            Assert.AreEqual("n/a", Kata1.AverageString(null));
        }

        [Test]
        public void SpecialInput()
        {
            Assert.AreEqual("n/a", Kata1.AverageString("six %%%  nine"));
        }

        [Test]
        public void CommaInput()
        {
            Assert.AreEqual("n/a", Kata1.AverageString("six , nine"));
        }




    }
}
