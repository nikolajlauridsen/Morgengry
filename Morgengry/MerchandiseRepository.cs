using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class MerchandiseRepository {
        private List<Merchandise> Merchandise = new List<Merchandise>();
        private Utility util = new Utility();

        public void AddMerchandise(Merchandise merchandise) {
            Merchandise.Add(merchandise);
        }

        public Merchandise GetMerchandise(int idx) {
            return Merchandise[idx];
        }

        public double GetTotalValue() {
            double price = 0;
            foreach(Merchandise merch in Merchandise) {
                price += util.GetValueOfMerchandise(merch);
            }
            return price;
        }

    }
}
