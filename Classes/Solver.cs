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

            var l0Sum = GetL0(queenPoint, n, obstacles);
            allSum += l0Sum;

            return allSum;
        }

        public int GetL0(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int c = queenPoint.Column;
            while(c > 0) {

                res++;
                c--;
                var cnt = obstacles.Where(x => x[0] == c).Count();
                if(cnt > 0) {
                    break;
                }
            }
            return res;
        }
    }
}
