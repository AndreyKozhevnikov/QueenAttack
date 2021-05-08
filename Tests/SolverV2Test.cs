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
        public void GetL2Start_0() {
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

        [Test]
        public void GetL4Start_0() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL4Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(2, 5));
        }
        [Test]
        public void GetL4Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 3);
            //act
            var res = s.GetL4Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(1, 4));
        }
        [Test]
        public void GetL4Start_3() {
            //arrange
            var s = new Solver();
            var q = new Point(1, 5);
            //act
            var res = s.GetL4Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(1, 5));
        }


        [Test]
        public void GetL6Start_0() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL6Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(4, 5));
        }
        [Test]
        public void GetL6Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL6Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 4));
        }
        [Test]
        public void GetL6Start_3() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 5);
            //act
            var res = s.GetL6Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 5));
        }


        [Test]
        public void GetL8Start_0() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 4);
            //act
            var res = s.GetL8Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 2));
        }
        [Test]
        public void GetL8Start_1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 3);
            //act
            var res = s.GetL8Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(4, 1));
        }
        [Test]
        public void GetL8Start_3() {
            //arrange
            var s = new Solver();
            var q = new Point(5, 1);
            //act
            var res = s.GetL8Start(q, 5);
            //assert
            Assert.AreEqual(res, new Point(5, 1));
        }

        [Test]
        public void GetTwoPointDiff() {
            //arrange

            var s = new Solver();
            var q = new Point(5,7 );
            var e = new Point(1, 3);
            //act
            var res = s.GetTwoPointDiff(q,e);
            //assert
            Assert.AreEqual(4, res);
        }
    }
}
