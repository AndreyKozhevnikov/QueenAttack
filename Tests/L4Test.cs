using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class L4Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL4(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 5);
            //act
            var res = s.GetL4(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 5);
            var q = new Point(3, 4);
            //act
            var res = s.GetL4(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 4);
            var q = new Point(3, 2);
            //act
            var res = s.GetL4(q, 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Get_Obstracle2() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 4);
            var q = new Point(3, 3);
            //act
            var res = s.GetL4(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
    }
}
