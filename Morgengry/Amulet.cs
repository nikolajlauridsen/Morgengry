using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public enum Level { low, medium, high }

    public class Amulet : Merchandise {
        public string Design; 
        public Level Quality;
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;

        public Amulet(string itemId, Level quality, string design) : base(itemId) {
            Quality = quality;
            Design = design;
        }

        public Amulet(String itemId): this(itemId, Level.medium, null) {
        }

        public Amulet(String itemId, Level quality): this(itemId, quality, null) {
        }



        public override string ToString() {
            return String.Format("ItemId: {0}, Quality: {1}, Design: {2}", ItemId, Quality, Design);
        }

        public override double GetValue() {
            switch (Quality) {
                case Level.high:
                    return HighQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                default:
                    return LowQualityValue;
            }
        }
    }
}
