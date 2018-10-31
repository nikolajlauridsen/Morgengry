using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {

    public abstract class Merchandise : IValuable {
        public string ItemId;

        public Merchandise(string itemId) {
            ItemId = itemId;
        }

        public override string ToString() {
            return "ItemId: " + ItemId;
        }

        public virtual double GetValue() {
            throw new NotImplementedException("This must be overwritten");
        }
    }
}
