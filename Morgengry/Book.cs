﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class Book : Merchandise {
        public string Title;
        public double Price;

        public Book(string itemId, string title, double price) : base(itemId) {
            Title = title;
            Price = price;
        }

        public Book(string itemId) : this(itemId, null, 0) {
        }

        public Book(string itemId, string title) : this(itemId, title, 0) {
        }

        public override string ToString() {
            return String.Format("ItemId: {0}, Title: {1}, Price: {2}", ItemId, Title, Price);
        }

        public override double GetValue() {
            return Price;
        }
    }
}
