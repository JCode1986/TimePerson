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
		public string BirthYear { get; set; }
		public string DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            //get the path of your timeperson.csv file
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");

            // create a list of Time persons (instantiate a new list)
            List<TimePerson> personsList = new List<TimePerson>();

            // read all the lines and save it into an array of strings
            var lines = File.ReadAllLines(path)
                                        .Skip(1);
            // traverse through the strings for each line item
            foreach (string line in lines)
            {
                // remember CSV is delimited by commas. 
                string[] rowColumn = line.Split(",");


                TimePerson timePerson = new TimePerson
                {
                    Year = Convert.ToInt32(rowColumn[0]),
                    Honor = rowColumn[1],
                    Name = rowColumn[2],
                    Country = rowColumn[3],
                    BirthYear = rowColumn[4],
                    DeathYear = rowColumn[5],
                    Title = rowColumn[6],
                    Category = rowColumn[7],
                    Context = rowColumn[8]
                };
                personsList.Add(timePerson);
            }
            // use LINQ to filter out with the years that you brought in against your list of persons
            

            //return your list of persons
            return personsList;
        }
    }

}
