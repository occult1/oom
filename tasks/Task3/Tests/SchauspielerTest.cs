using Task2;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class SchauspielerTest
    {
        [Test]
        public void CanCreatSchauspieler()
        {
            var s = new Schauspieler("Mr X");
            Assert.IsTrue(s.Name == "MR X");
            Assert.IsTrue(s.Rolle == myEnums.Rolle.Schauspieler);
        }

        [Test]
        public void CannotCreatSchauspieler()
        {
            Assert.Catch(() =>
            {
                var s = new Schauspieler(null);
            });
        }
    }
}
