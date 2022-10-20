using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class DistanceUnit {
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public override string ToString(){
            return this.Name;
        }
    }
    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name = "mm",Coefficient = 1,},
            new MetricUnit{Name = "cm",Coefficient = 10,},
            new MetricUnit{Name = "m",Coefficient = 10 * 100,},
            new MetricUnit{Name = "km",Coefficient = 10 * 100 * 1000,},
        };

        public static ICollection<MetricUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>

        public double FromImperialUnit(ImperiaUnit unit, double value)
        {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }
    //ヤード単位を表すクラス
    public class ImperiaUnit : DistanceUnit {
        private static List<ImperiaUnit> units = new List<ImperiaUnit> {

            new ImperiaUnit{Name = "in", Coefficient = 1,},
            new ImperiaUnit{Name = "ft", Coefficient = 12,},
            new ImperiaUnit{Name = "yd", Coefficient = 12 * 3,},
            new ImperiaUnit{Name = "ml", Coefficient = 12 * 3 * 1760,},
        };

        public static ICollection<ImperiaUnit> Units { get { return units; } }

        public double FromMetricUnit(MetricUnit unit, double value)
        {
            return (value * unit.Coefficient) / 25.4 / this.Coefficient;
        }
    }
}
