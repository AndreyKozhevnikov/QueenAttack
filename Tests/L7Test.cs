using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class L7Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL7(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 4);
            //act
            var res = s.GetL7(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 3);
            var obs = new ObstaclesHolder();
            obs.Add(4, 2);
            //act
            var res = s.GetL7(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle1() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 3);
            var obs = new ObstaclesHolder();
            obs.Add(5, 1);
            //act
            var res = s.GetL7(q, 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Get_Obstracle2() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 3);
            var obs = new ObstaclesHolder();
            obs.Add(2, 2);
            //act
            var res = s.GetL7(q, 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
    }
}
