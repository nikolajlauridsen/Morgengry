using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry {
    public class CourseRepository {
        private List<Course> courses = new List<Course>();
        Utility util = new Utility();

        public void AddCourse(Course course) {
            courses.Add(course);
        }

        public Course GetCourse(string name) {
            foreach(Course course in courses) {
                if (course.Name.Equals(name)) {
                    return course;
                }
            }
            return null;
        }

        public double GetTotalValue() {
            double value = 0;
            foreach(Course course in courses) {
                value += util.GetValueOfCourse(course);
            }
            return value;
        }
    }
}
