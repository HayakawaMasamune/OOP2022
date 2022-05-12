using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public class InchConverter {
        //メートルからインチを求める
        public double FromMeter(double meter)
        {
            return meter / 0.0254;
        }
        public double ToMeter(double inch )
        {

            return inch * 0.0254;
        }
    }
}
