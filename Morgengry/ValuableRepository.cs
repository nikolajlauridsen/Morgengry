using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morgengry {
    public class ValuableRepository : IPersistable {
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

        public void Save()
        {
            Save("ValuableRepository.txt");
        }

        public void Save(string filename)
        {
            StringBuilder src = new StringBuilder();
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Book book)
                {
                    src.Append("BOG;");
                    src.Append(book.ItemId + ";");
                    src.Append(book.Title + ";");
                    src.Append(book.Price);
                    src.Append("\n");
                }
                else if (valuable is Amulet amulet)
                {
                    src.Append("AMULET;");
                    src.Append(amulet.ItemId + ";");
                    src.Append(amulet.Design + ";");
                    src.Append(amulet.Quality);
                    src.Append("\n");
                }
                else if (valuable is Course course)
                {
                    src.Append("COURSE;");
                    src.Append(course.Name + ";");
                    src.Append(course.DurationInMinutes + ";");
                    src.Append(course.CourseHourValue);
                    src.Append("\n");
                }
            }
            SaveTextFile(filename, src.ToString());
        }

        public void Load()
        {
            Load("ValuableRepository.txt");
        }

        public void Load(string filename)
        {
            string[] src = LoadTextFile(filename);

            foreach(string line in src)
            {
                string[] elements = line.Split(';');
                switch (elements[0])
                {
                    case "BOG":
                        Book book = new Book(elements[1]);
                        if (ElementExists(elements[2]))
                        {
                            book.Title = elements[2];
                        }
                        book.Price = Double.Parse(elements[3]);
                        valuables.Add(book);
                        break;

                    case "AMULET":
                        Amulet amulet = new Amulet(elements[1]);
                        // Set design
                        if(ElementExists(elements[2]))
                        {
                            amulet.Design = elements[2];
                        }
                        // Set quality
                        if(elements[3] == Level.low.ToString())
                        {
                            amulet.Quality = Level.low;
                        } else if(elements[3] == Level.medium.ToString())
                        {
                            amulet.Quality = Level.medium;
                        } else if(elements[3] == Level.high.ToString())
                        {
                            amulet.Quality = Level.high;
                        }
                        valuables.Add(amulet);
                        break;

                    case "COURSE":
                        Course course = new Course(elements[1]);
                        course.DurationInMinutes = int.Parse(elements[2]);
                        course.CourseHourValue = double.Parse(elements[3]);
                        valuables.Add(course);
                        break;
                }
            }
        }

        private void SaveTextFile(string path, string text)
        {
            File.WriteAllText(@path, text);
        }

        private String[] LoadTextFile(string path)
        {
            return File.ReadAllLines(@path);
        }

        private bool ElementExists(string element)
        {
            if (element.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
