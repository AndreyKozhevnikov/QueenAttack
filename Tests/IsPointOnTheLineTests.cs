using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class IsPointOnTheLineTests {
        [Test]
        public void IsPointOnTheLine_Test0() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 7);
            var e = new Point(1, 3);
            var obs = new Point(3, 5);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(true, res);
        }
        [Test]
        public void IsPointOnTheLine_Test1() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 7);
            var e = new Point(1, 3);
            var obs = new Point(3, 6);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(false, res);
        }

        [Test]
        public void IsPointOnTheLine_Test2() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 4);
            var e = new Point(5, 5);
            var obs = new Point(5, 5);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(true, res);
        }
        [Test]
        public void IsPointOnTheLine_Test3() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            var e = new Point(4, 5);
            var obs = new Point(4, 2);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(false, res);
        }

        [Test]
        public void IsPointOnTheLine_TestVert() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 7);
            var e = new Point(1, 7);
            var obs = new Point(3, 7);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(true, res);
        }

        [Test]
        public void IsPointOnTheLine_TestHorizont() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 7);
            var e = new Point(5, 3);
            var obs = new Point(5, 4);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(true, res);
        }

        [Test]
        public void IsPointOnTheLine_OutOfLine() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            var e = new Point(2, 5);
            var obs = new Point(4, 3);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(false, res);
        }

        [Test]
        public void IsPointOnTheLine_OutOfLine_1() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            var e = new Point(4, 5);
            var obs = new Point(2, 3);
            //act
            var res = s.IsPointOnTheLine(q, e, obs);
            //assert
            Assert.AreEqual(false, res);
        }
    }
}
