using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack.Classes {
    [DebuggerDisplay("r={Row},c={Column}")]
  public  class Point {
        public Point(int r, int c) {
            Row = r;
            Column = c;
        }
        public int Row{ get; set; }
        public int Column{ get; set; }

        public override bool Equals(object obj) {
            var p = obj as Point;
            if(p != null) {
                return p.Row == this.Row && p.Column == this.Column;
            }
            return base.Equals(obj);
        }

        public override string ToString() {
            return string.Format("r-{0}, c-{1}", Row, Column);
        }
    }
}
