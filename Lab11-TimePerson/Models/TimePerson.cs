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
        /// Method that returns a list of people after query
        /// </summary>
        /// <param name="startYear">int</param>
        /// <param name="endYear">int</param>
        /// <returns>list of people</returns>
        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {  
            //pathing to wwwroot/csv file
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot/personOfTheYear.csv"));

            //list instantiation with all the properties from csv.file
            List<TimePerson> personList = new List<TimePerson>();

            //skipping one to avoid titles, and no interference with string to int
            var lines = File.ReadAllLines(newPath)
                                        .Skip(1);

            //traverse through the strings for each line item
            foreach (string line in lines)
            {
                //split by commas to retrieve word for specific heading 
                string[] rowColumn = line.Split(",");

                //instantiating new timeperson with values from csv.file
                TimePerson timePerson = new TimePerson
                {
                    Year = Convert.ToInt32(rowColumn[0]),
                    Honor = rowColumn[1] != "" ? rowColumn[1] : "N/A",
                    Name = rowColumn[2] != "" ? rowColumn[2] : "N/A",
                    Country = rowColumn[3] != "" ? rowColumn[3] : "N/A",
                    BirthYear = rowColumn[4] != "" ? rowColumn[4] : "N/A",
                    DeathYear = rowColumn[5] != "" ? rowColumn[5] : "N/A",
                    Title = rowColumn[6] != "" ? rowColumn[6] : "N/A",
                    Category = rowColumn[7] != "" ? rowColumn[7] : "N/A",
                    Context = rowColumn[8] != "" ? rowColumn[8] : "N/A"
                };
                //add all the new instantiated values to list
                personList.Add(timePerson);
            }

            //utilizing LINQ to filter out according to user input on start year and end year
            var query = personList
                                .Where(p => p.Year >= startYear && p.Year <= endYear)
                                .OrderBy(p => p.Year).ToList();
            
            //return result list
            return query;
        }
    }

}
