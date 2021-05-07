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
        [Test]
        [Ignore]
        public void SolveTest() {
            //arrange
            var s = new Solver();

            var obstacle = new List<int>();
            obstacle.Add(1);
            obstacle.Add(1);
            var allList = new List<List<int>>();
            allList.Add(obstacle);
            //act
            var res = s.Solve(5, 1, 2, 3, allList);
            //assert
            Assert.AreEqual(11, res);

        }
    }

    [TestFixture]
    public class L0Test {
        [Test]
        public void Get0() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL0(new Point(2, 3), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(3, res);
        }
        [Test]
        public void Get0_1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL0(new Point(2, 0), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get0_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 1);
            //act
            var res = s.GetL0(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Get0_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 2);
            //act
            var res = s.GetL0(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
    }
    [TestFixture]
    public class L1Test {


        [Test]
        public void Get1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL1(new Point(2, 3), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get1_1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL1(new Point(0, 1), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get1_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(1, 2);
            //act
            var res = s.GetL1(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get0_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2, 1);
            //act
            var res = s.GetL0(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
    }
    [TestFixture]
    public class L2Test {


        [Test]
        public void Get() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL2(new Point(2, 3), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Get_1() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL2(new Point(0, 3), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(1, 3);
            //act
            var res = s.GetL2(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get0_Obstracle1() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(0, 3);
            //act
            var res = s.GetL2(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
    }

}
