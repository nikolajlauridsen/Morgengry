using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    class Book {
        public string ItemID;
        public string Title;
        public double Price;

        Book(string itemId) {
            ItemID = itemId;
        }

        Book(string itemId, string title) {
            ItemID = itemId;
            Title = title;
        }

        Book(string itemId, string title, double price) {
            ItemID = itemId;
            Title = title;
            Price = price;
        }

        public override string ToString() {
            return "A book";
        }
    }
}
