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
            var res = s.GetL0(new Point(2, 0), 5, null);
            //assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Get0_Obstracle() {
            //arrange
            var s = new Solver();
            var obs = new ObstaclesHolder();
            obs.Add(2,1);
            //act
            var res = s.GetL0(new Point(2, 3), 5, obs.Result);
            //assert
            Assert.AreEqual(1, res);
        }
    }
}
