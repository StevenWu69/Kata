using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Kata2
{
    [TestFixture]
    public class Kata2Test
    {
        [Test]
        public void DeadAntsAllSurvive()
        {
            Assert.AreEqual(0, Kata2.DeadAnts(".ant..ant..."));
        }

        [Test]
        public void NoAnts()
        {
            Assert.AreEqual(0, Kata2.DeadAnts(""));
        }

        [Test]
        public void Blank()
        {
            Assert.AreEqual(0, Kata2.DeadAnts("   "));
        }

        [Test]
        public void Ants4()
        {
            Assert.AreEqual(4, Kata2.DeadAnts("..aant a nt an t anttt "));
        }

        [Test]
        public void Ants2()
        {
            Assert.AreEqual(2, Kata2.DeadAnts("ant anantt aantt "));
        }
    }
}
