using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_TimePerson.Models
{
    public class TimePerson
    {
		public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }
        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            //get the path of your timeperson.csv file
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/TimePerson.csv");

            // create a list of Time persons (instantiate a new list)
            List<TimePerson> personsList = new List<TimePerson>();

            // read all the lines and save it into an array of strings
            var lines = File.ReadAllLines(path);

            // traverse through the strings for each line item
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // remember CSV is delimited by commas. 

            // use LINQ to filter out with the years that you brought in against your list of persons

            //return your list of persons

            return null;
        }
    }

}
