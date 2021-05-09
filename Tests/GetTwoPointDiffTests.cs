using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class GetTwoPointDiffTests {
        [Test]
        public void GetTwoPointDiff() {
            //arrange

            var s = new Solver();
            var q = new Point(5, 7);
            var e = new Point(1, 3);
            var obs = new ObstaclesHolder();
            //act
            var res = s.GetTwoPointDiff(q, e, obs.Result);
            //assert
            Assert.AreEqual(4, res);
        }

        [Test]
        public void GetTwoPointDiff_1() {
            //arrange

            var s = new Solver();
            var q = new Point(3, 4);
            var e = new Point(2, 5);
            var obs = new ObstaclesHolder();
            obs.Add(4, 3);
            //act
            var res = s.GetTwoPointDiff(q, e, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void GetTwoPointDiff_obs0() {
            //arrange

            var s = new Solver();
            var q = new Point(5, 7);
            var e = new Point(1, 3);
            var obs = new ObstaclesHolder();
            obs.Add(3, 5);
            //act
            var res = s.GetTwoPointDiff(q, e, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void GetTwoPointDiff_obs1() {
            //arrange

            var s = new Solver();
            var q = new Point(6, 6);
            var e = new Point(1, 1);
            var obs = new ObstaclesHolder();
            obs.Add(3, 3);
            obs.Add(4, 4);
            //act
            var res = s.GetTwoPointDiff(q, e, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void GetTwoPointDiff_obs2() {
            //arrange

            var s = new Solver();
            var q = new Point(4, 3);
            var e = new Point(4, 5);
            var obs = new ObstaclesHolder();
            obs.Add(5, 5);
            obs.Add(4, 2);
            obs.Add(2, 3);
            //act
            var res = s.GetTwoPointDiff(q, e, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
      
    }
}
