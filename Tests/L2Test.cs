using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class L2Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL2(new Point(3, 4), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL2(new Point(1, 4), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 4);
            //act
            var res = s.GetL2(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get2_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(1, 4);
            //act
            var res = s.GetL2(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get2_Obstracle2() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(1, 1);
            //act
            var res = s.GetL2(new Point(3, 4), 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
    }
}
