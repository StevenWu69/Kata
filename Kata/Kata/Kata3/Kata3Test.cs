using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Kata3
{
    [TestFixture]
    public class Kata3Test
    {
        [Test]
        public void NormalName()
        {
            Assert.AreEqual("The Abc", Kata3.BandNameGenerator("abc"));
        }

        [Test]
        public void HeadEqualstoTail()
        {
            Assert.AreEqual("Abcabca", Kata3.BandNameGenerator("abca"));
        }

        [Test]
        public void SpecialHead1()
        {
            Assert.AreEqual("The !abc", Kata3.BandNameGenerator("!abc"));
        }

        [Test]
        public void SpecialHead2()
        {
            Assert.AreEqual("The 0abc", Kata3.BandNameGenerator("0abc"));
        }

        [Test]
        public void BlankInput()
        {
            Assert.AreEqual("invalid input", Kata3.BandNameGenerator(" "));
        }

        [Test]
        public void BlankWithName()
        {
            Assert.AreEqual("invalid input", Kata3.BandNameGenerator(" abc"));
        }

        [Test]
        public void SingleInput1()
        {
            Assert.AreEqual("The A", Kata3.BandNameGenerator("a"));
        }

        [Test]
        public void SingleInput2()
        {
            Assert.AreEqual("The ?", Kata3.BandNameGenerator("?"));
        }
    }
}
