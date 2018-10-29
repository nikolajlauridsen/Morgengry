using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morgengry;

namespace Morgengry {
    public class Utility {
        public static double GetValueOfBook(Book book) {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet) {
            switch (amulet.Quality) {
                case Level.high:
                    return 27.5;
                case Level.medium:
                    return 20.0;
                default:
                    return 12.5;
            }
        }

        public static double GetValueOfCourse(Course course) { 
            int wholeHours = (int) course.DurationInMinutes / 60;
            double price = 875 * wholeHours;
            if((course.DurationInMinutes % 60) != 0) {
                price += 875;
            }
            return price;
        }
    }
}
