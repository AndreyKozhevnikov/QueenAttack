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
        public void SolveTest_s0() {
            //arrange
            var s = new Solver();

            var obs = new ObstaclesHolder();
            
            //act
            var res = s.Solve(5, 1, 3, 4, obs.Result);
            //assert
            Assert.AreEqual(14, res);
        }
        [Test]
        public void SolveTest_s1() {
            //arrange
            var s = new Solver();

            var obs = new ObstaclesHolder();

            //act
            var res = s.Solve(6, 1, 3, 4, obs.Result);
            //assert
            Assert.AreEqual(19, res);
        }
        
        [Test]
        public void SolveTest() {
            //arrange
            var s = new Solver();

            var obs = new ObstaclesHolder();
            obs.Add(4, 3);
            //act
            var res = s.Solve(5, 1, 3, 4, obs.Result);
            //assert
            Assert.AreEqual(12, res);

        }
        
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
        
        [Test]
        public void SolveTest_Time() {
            //arrange
            var s = new Solver();
            var k = 50000;
            var obs = new ObstaclesHolder();
            var r = new Random();
            for(int i = 0; i < 10000; i++) {
                var row = r.Next(1, k);
                var column = r.Next(1, k);
                obs.Add(row, column);
            }
            //obs.Add(5, 5);
            //obs.Add(4, 2);
            //obs.Add(2, 3);
            //act
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var res = s.Solve(k, 3, 4, 3, obs.Result);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            //assert
            Assert.Less(elapsedMs, 10000);

        }
    }
}
