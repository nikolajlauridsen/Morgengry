using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class AmuletRepository {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet) {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(int itemId) {
            foreach(Amulet amulet in amulets) {
                if (amulet.ItemId.Equals(itemId)) {
                    return amulet;
                }
            }
            return null;
        }

        public double GetTotalValue() {
            double value = 0;
            foreach(Amulet amulet in amulets) {
                value += Utility.GetValueOfAmulet(amulet);
            }
            return value;
        }
    }
}
