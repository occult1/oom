using NUnit.Framework;
using System.Collections.Generic;
using Task4;
namespace Tests
{
    [TestFixture]
    class MyFilmTest
    {

        [Test]
        public void CanCreatFilm_1()
        {
            var f = new Film(1990, "Movie");

            Assert.IsTrue(f.Jahr == 1990);
            Assert.IsTrue(f.Titel == "Movie");
        }

        [Test]
        public void CanCreatFilm_2()
        {
            var s = new Schauspieler("Mr X");
            var f = new Film(s, 1990, "Movie");

            Assert.IsTrue(s.Name == "Mr X");
            Assert.IsTrue(s.Rolle == myEnums.Rolle.Schauspieler);
            Assert.IsTrue(f.Jahr == 1990);
            Assert.IsTrue(f.Titel == "Movie");
            //CanCreatFilm_1();
            //SchauspielerTest st = new SchauspielerTest();
            //st.CanCreatSchauspieler();
        }

        [Test]
        public void CannotCreatFilmWithYearLesser0_1()
        {

            Assert.Catch(() =>
            {
                var f = new Film(-1, "Movie");
            });
        }

        [Test]
        public void CannotCreatFilmWithYearLesser0_2()
        {
            Assert.Catch(() =>
            {
                var f = new Film(new Schauspieler("Mr X"), -1, "Movie");
            });
        }


        [Test]
        public void CannotCreatFilmWithoutTitel_1()
        {
            Assert.Catch(() =>
            {
                var f = new Film(2000, null);
            });
        }

        [Test]
        public void CannotCreatFilmWithoutTitel_2()
        {
            Assert.Catch(() =>
            {
                var f = new Film(new Schauspieler("Mr X"), 2000, null);
            });
        }

        [Test]
        public void CannotUpDateTitelWithoutTitel()
        {
            Assert.Catch(() =>
            {
                var f = new Film(2000, "Movie");
                f.UpdateTitle(null);
            });

        }


        [Test]
        public void CannAddKameramann()
        {
            var x = new List<Kameramann>();
            var f = new Kameramann("Paul");
            x.Add(f);
            Assert.IsTrue(x != null);
        }

        [Test]
        public void CanAddSchauspieler()
        {
            var f = new Film(2000, "Movie");
            f.AddSchauspieler(new Schauspieler("Mir X"));
            Assert.IsTrue(f != null);
        }
    }
}
