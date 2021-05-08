using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack.Classes {

    class SolverV2 {
        public int SolveV2(int n, int k, int r_q, int c_q, List<List<int>> obstacles) {
            var allSum = 0;

            return allSum;
        }

    }


    class Solver {
        public int SolveV2(int n, int k, int r_q, int c_q, List<List<int>> obstacles) {
            var allSum = 0;

            return allSum;
        }
        public int Solve(int n, int k, int r_q, int c_q, List<List<int>> obstacles) {
            return SolveV2(n, k, r_q, c_q, obstacles);
        }
        public int SolveV1(int n, int k, int r_q, int c_q, List<List<int>> obstacles) {
            var allSum = 0;

            var queenPoint = new Point(r_q, c_q);

            var l0Sum = GetL0(queenPoint, n, obstacles);
            allSum += l0Sum;

            var l1Sum = GetL1(queenPoint, n, obstacles);
            allSum += l1Sum;

            var l2Sum = GetL2(queenPoint, n, obstacles);
            allSum += l2Sum;

            var l3Sum = GetL3(queenPoint, n, obstacles);
            allSum += l3Sum;

            var l4Sum = GetL4(queenPoint, n, obstacles);
            allSum += l4Sum;

            var l5Sum = GetL5(queenPoint, n, obstacles);
            allSum += l5Sum;

            var l6Sum = GetL6(queenPoint, n, obstacles);
            allSum += l6Sum;

            var l7Sum = GetL7(queenPoint, n, obstacles);
            allSum += l7Sum;

            return allSum;
        }

        public int GetL0(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;

            while(c > 1) {
                c--;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
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
            int c = queenPoint.Column;
            while(r > 1) {
                r--;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }

        public int GetL4(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;

            while(c < n) {
                c++;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }

        public int GetL6(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;

            while(r < n) {
                r++;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
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

            while(r > 1 && c > 1) {
                r--;
                c--;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }

        public int GetL3(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;

            while(r > 1 && c < n) {
                r--;
                c++;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }

        public int GetL5(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;

            while(r < n && c < n) {
                r++;
                c++;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }

        public int GetL7(Point queenPoint, int n, List<List<int>> obstacles) {
            int res = 0;
            int r = queenPoint.Row;
            int c = queenPoint.Column;

            while(r < n && c > 1) {
                r++;
                c--;
                var cnt = obstacles.Where(x => x[0] == r && x[1] == c).Count();
                if(cnt > 0) {
                    break;
                }
                res++;
            }
            return res;
        }
    }
}
