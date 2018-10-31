using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class ValuableRepository {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable) {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id) {
            foreach(IValuable valuable in valuables) {
                if(valuable is Merchandise merchandise) {
                    if (merchandise.ItemId.Equals(id)) {
                        return valuable;
                    }
                } else if (valuable is Course course) {
                    if (course.Name.Equals(id)) {
                        return valuable;
                    }
                }
            }
            throw new Exception("No valuable with that ID exists");
        }

        public double GetTotalValue() {
            double price = 0;
            foreach(IValuable valuable in valuables) {
                price += valuable.GetValue();
            }
            return price;
        }

        public int Count() {
            return valuables.Count;
        }
    }
}
