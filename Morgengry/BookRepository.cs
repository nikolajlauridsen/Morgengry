using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class BookRepository {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) {
            books.Add(book);
        }

        public Book GetBoook(string itemId) {
            foreach(Book book in books) {
                if(book.ItemId.Equals(itemId)) {
                    return book;
                }
            }
            return null;
        }

        public double GetTotalValue() {
            double value = 0;

            foreach(Book book in books) {
                value += Utility.GetValueOfBook(book);
            }

            return value;
        }

    }
}
