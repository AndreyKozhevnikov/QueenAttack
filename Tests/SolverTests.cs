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
        public void SolveTest() {
            //arrange
            var s = new Solver();
            
            var obstacle = new List<int>();
            obstacle.Add(1);
            obstacle.Add(1);
            var allList = new List<List<int>>();
            allList.Add(obstacle);
            //act
            var res = s.Solve(5, 1, 3, 3, allList);
            //assert
            Assert.AreEqual(12, res);

        }
    }
}
