using Task2;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class KammeramanTest
    {
        [Test]
        public void CanCreatSchauspieler()
        {
            var s = new Kameramann("Mr K");
            Assert.IsTrue(s.Name == "MR K");
            Assert.IsTrue(s.Rolle == myEnums.Rolle.Kameramann);
        }

        [Test]
        public void CannotCreatSchauspieler()
        {
            Assert.Catch(() =>
            {
                var s = new Kameramann(null);
            });
        }
    }
}
