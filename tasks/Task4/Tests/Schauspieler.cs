using NUnit.Framework;
using Task4;

namespace Tests
{
    [TestFixture]
    public class SchauspielerTest
    {
        [Test]
        public void CanCreatSchauspieler()
        {
            var s = new Schauspieler("Mr X");
            Assert.IsTrue(s.Name == "Mr X");
            Assert.IsTrue(s.Rolle == myEnums.Rolle.Schauspieler);
        }

        [Test]
        public void CannotCreatSchauspieler()
        {
            Assert.Catch(() =>
            {
                var s = new Schauspieler("");
            });
        }
    }
}
