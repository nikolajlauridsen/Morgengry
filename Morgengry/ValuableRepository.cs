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
            throw new NotImplementedException();
        }

        public void Load(string filename)
        {
            throw new NotImplementedException();
        }

        private void SaveTextFile(string path, string text)
        {
            File.WriteAllText(@path, text);
        }

        private String[] LoadTextFile(string path)
        {
            return File.ReadAllLines(@path);
        }
    }
}
