using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class Book {
        public string ItemID;
        public string Title;
        public double Price;

        public Book(string itemId) {
            ItemID = itemId;
        }

        public Book(string itemId, string title) {
            ItemID = itemId;
            Title = title;
        }

        public Book(string itemId, string title, double price) {
            ItemID = itemId;
            Title = title;
            Price = price;
        }

        public override string ToString() {
            return "A book";
        }
    }
}
