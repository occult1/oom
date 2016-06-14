using NUnit.Framework;
using Task4;

namespace Tests
{
    [TestFixture]
    public class KammeramanTest
    {
        [Test]
        public void CanCreatSchauspieler()
        {
            var s = new Kameramann("Mr K");
            Assert.IsTrue(s.Name == "Mr K");
            Assert.IsTrue(s.Rolle == myEnums.Rolle.Kameramann);
        }

        [Test]
        public void CannotCreatSchauspieler()
        {
            Assert.Catch(() =>
            {
                var s = new Kameramann("");
            });
        }
    }
}
