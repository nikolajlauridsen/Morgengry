using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class MerchandiseRepository {
        private List<Merchandise> Merchandise = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise) {
            Merchandise.Add(merchandise);
        }

        public Merchandise GetMerchandise(int idx) {
            return Merchandise[idx];
        }

        public double GetValueOfMerchandise(Merchandise merchandise) {
            if (merchandise is Book book) {
                return book.Price;
            } else if (merchandise is Amulet amulet) {
                switch (amulet.Quality) {
                    case Level.high:
                        return 27.5;
                    case Level.medium:
                        return 20.0;
                    default:
                        return 12.5;
                }
            } else {
                return 0;
            }
        }
    }
}
