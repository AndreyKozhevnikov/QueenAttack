using NUnit.Framework;
using QueenAttack.Classes;

namespace QueenAttack.Tests {
    [TestFixture]
    public class SolverV2 {
        [Test]
        public void GetL1Start() {
            //arrange
            var s = new Solver();
            //act
            var res = s.GetL0(new Point(3, 4), 5, new ObstaclesHolder().Result);
            //assert
            Assert.AreEqual(3, res);
        }
    }
}
