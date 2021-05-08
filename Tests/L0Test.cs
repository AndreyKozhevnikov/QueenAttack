using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class L0Test {
        [Test]
        public void Get0() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL0(new Point(3, 4), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(3, res);
        }
        [Test]
        public void Get0_1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL0(new Point(3, 1), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get0_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 2);
            //act
            var res = s.GetL0(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get0_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 3);
            //act
            var res = s.GetL0(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get0_Obstracle2() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 3);
            //act
            var res = s.GetL0(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(3, res);
        }
    }
}
