using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack.Classes {
    class Solver {

        public int Solve(int n, int k, int r_q, int c_q, List<List<int>> obstacles) {
            var allSum = 0;

            var queenPoint = new Point(r_q, c_q);
            var l1First = new Point(r_q, 0);
            var l1Sum = queenPoint.Column - l1First.Column;
            allSum = allSum + l1Sum;


            return allSum;
        }
    }
}
