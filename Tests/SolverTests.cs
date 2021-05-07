using NUnit.Framework;
using QueenAttack.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack.Tests {
    [TestFixture]
    public class SolverTests {
        [Ignore]
        [Test]
        public void SolveTest() {
            //arrange
            var s = new Solver();

            var obs = new ObstaclesHolder();
            obs.Add(1, 2);
            //act
            var res = s.Solve(5, 1, 2, 3, obs.Result);
            //assert
            Assert.AreEqual(12, res);

        }
        [Ignore]
        [Test]
        public void SolveTest_1() {
            //arrange
            var s = new Solver();

            var obs = new ObstaclesHolder();
            obs.Add(5, 5);
            obs.Add(4, 2);
            obs.Add(2, 3);
            //act
            var res = s.Solve(5, 3, 4, 3, obs.Result);
            //assert
            Assert.AreEqual(10, res);

        }
    }

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

    [TestFixture]
    public class L3Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL3(new Point(3, 4), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(3, 5);
            //act
            var res = s.GetL3(q, 5, new ObstaclesHolder().Result);
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
            var res = s.GetL3(q, 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get3_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(3, 4);
            var q = new Point(3, 2);
            //act
            var res = s.GetL3(q, 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }

        [Test]
        public void Get3_Obstracle2() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 4);
            var q = new Point(3, 3);
            //act
            var res = s.GetL3(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
    }

    [TestFixture]
    public class L4Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 3);
            //act
            var res = s.GetL4(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 4);
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
            obs.Add(2, 4);
            var q = new Point(2, 3);
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
            obs.Add(2, 3);
            var q = new Point(2, 1);
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
            obs.Add(2, 3);
            var q = new Point(2, 2);
            //act
            var res = s.GetL4(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
    }
    [TestFixture]
    public class L5Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 3);
            //act
            var res = s.GetL5(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 4);
            //act
            var res = s.GetL5(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(3, 3);
            //act
            var res = s.GetL5(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(4, 4);
            //act
            var res = s.GetL5(q, 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Get_Obstracle2() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(1, 3);
            //act
            var res = s.GetL5(q, 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
    }
    [TestFixture]
    public class L6Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 3);
            //act
            var res = s.GetL6(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL6(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(3, 2);
            //act
            var res = s.GetL6(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(4, 2);
            //act
            var res = s.GetL6(q, 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Get_Obstracle2() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(3, 0);
            //act
            var res = s.GetL6(q, 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
    }

    [TestFixture]
    public class L7Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 3);
            //act
            var res = s.GetL7(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            var q = new Point(4, 3);
            //act
            var res = s.GetL7(q, 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(3, 1);
            //act
            var res = s.GetL7(q, 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle1() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(4, 0);
            //act
            var res = s.GetL7(q, 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Get_Obstracle2() {
            //arrange
            var s = new Solver();
            var q = new Point(2, 2);
            var obs = new ObstaclesHolder();
            obs.Add(1, 1);
            //act
            var res = s.GetL7(q, 5, obs.Result);
            //assert
            Assert.AreEqual(2, res);
        }
    }
}
