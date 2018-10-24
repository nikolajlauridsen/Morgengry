using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public enum Level { low, medium, high }

    public class Amulet {
        public string ItemId;
        public string Design;
        
        public Level Quality;

        public Amulet(String itemId) {
            ItemId = itemId;
        }

        public Amulet(String itemId, Level quality) {
            ItemId = itemId;
            Quality = quality;
        }

        public Amulet(String itemId, Level quality, String design) {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString() {
            return "Amulet";
        }
    }
}
