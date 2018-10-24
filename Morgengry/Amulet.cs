using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    class Amulet {
        public string ItemId;
        public string Design;
        public enum Level { low, medium, high}
        public Level Quality;

        Amulet(String itemId) {
            ItemId = itemId;
        }

        Amulet(String itemId, Level quality) {
            ItemId = itemId;
            Quality = quality;
        }

        Amulet(String itemId, Level quality, String design) {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString() {
            return "Amulet";
        }
    }
}
