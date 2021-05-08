using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class L1Test {


        [Test]
        public void Get1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL1(new Point(3, 4), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get1_1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL1(new Point(1, 2), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get1_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 3);
            //act
            var res = s.GetL1(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 2);
            var q = new Point(3, 4);
            //act
            var res = s.GetL1(q, 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }

        [Test]
        public void Get1_Obstracle2() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 1);
            //act
            var res = s.GetL1(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
    }
}
