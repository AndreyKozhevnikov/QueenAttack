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

            var l1Sum = GetL1(queenPoint, n, obstacles);
            allSum += l1Sum;

            var l2Sum = GetL2(queenPoint, n, obstacles);
            allSum += l2Sum;

            return allSum;
        }

        public int GetL0(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int c = queenPoint.Column;
            while(c > 0) {
                c--;
                var cnt = obstacles.Where(x => x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }
        public int GetL2(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            while(r > 0) {
                r--;
                var cnt = obstacles.Where(x => x[0] == r).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }
        public int GetL1(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;
            
            while(r > 0 && c > 0) {
                r--;
                c--;
                var cnt = obstacles.Where(x => x[0] == r).Count();
                var cnt2 = obstacles.Where(x => x[1] == c).Count();
                if(cnt > 0 || cnt2 > 0) {
                    break;
                }
                res++;
            }
            return res;
        }
    }
}
