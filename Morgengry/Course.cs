using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class Course : IValuable {
        public string Name;
        public int DurationInMinutes;
        public double CourseHourValue = 825;

        public Course(string name, int duration) {
            Name = name;
            DurationInMinutes = duration;
        }

        public Course(string name) : this(name, 0) {

        }

        public override string ToString() {
            return String.Format("Name: {0}, Duration in Minutes: {1}, Pris pr påbegyndt time: {2}", Name, DurationInMinutes, CourseHourValue);
        }

        public double GetValue() {
            int wholeHours = (int)DurationInMinutes / 60;
            double price = CourseHourValue * wholeHours;
            if ((DurationInMinutes % 60) != 0) {
                price += CourseHourValue;
            }
            return price;
        }

    }
}
