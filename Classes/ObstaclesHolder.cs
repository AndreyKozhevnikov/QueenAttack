using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenAttack.Classes {
   public class ObstaclesHolder {
        public ObstaclesHolder() {
            Result = new List<List<int>>();
        }
        public void Add(int r, int c) {
            var l = new List<int>();
            l.Add(r);
            l.Add(c);
            Result.Add(l);
        }
        public List<List<int>> Result;
    }
}
