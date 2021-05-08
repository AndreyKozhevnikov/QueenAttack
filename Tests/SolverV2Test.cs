using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class SolverV2Test {
        [Test]
        public void GetL1Start() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL1Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(3,1));
        }
        [Test]
        public void GetL1Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL1Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(4, 1));
        }
        [Test]
        public void GetL1Start_2() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 1);
            //act
            var res = s.GetL1Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(4, 1));
        }
        [Test]
        public void GetL3Start() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL3Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(1, 4));
        }
        [Test]
        public void GetL3Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL3Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(1, 3));
        }

        [Test]
        public void GetL5Start() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL5Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(3, 5));
        }
        [Test]
        public void GetL5Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL5Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(4, 5));
        }

        [Test]
        public void GetL7Start() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL7Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 4));
        }
        [Test]
        public void GetL7Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL7Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 3));
        }


        [Test]
        public void GetL2Start() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL2Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(1, 2));
        }
        [Test]
        public void GetL2Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL2Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(2, 1));
        }
        [Test]
        public void GetL2Start_3() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 1);
            //act
            var res = s.GetL2Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 1));
        }


    }
}
