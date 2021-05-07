using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack.Classes {
  public  class Point {
        public Point(int r, int c) {
            Row = r;
            Column = c;
        }
        public int Row{ get; set; }
        public int Column{ get; set; }
    }
}
