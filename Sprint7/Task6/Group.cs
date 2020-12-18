using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Sprint7.Task6
{
    public class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Popularity { get; set; }

        public Group(string n, string d, int p)
        {
            Name = n;
            Description = d;
            Popularity = p;
        }
        public static string CreateGroups(List<Student> students, List<Group> groups)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var rat = students.Select(s => s.Rating).Aggregate((x, y) => x + y) / (double)students.Count();
            Console.WriteLine(rat);
            var result = groups.GroupJoin(students, g => g.Name, s => s.GroupName, (g, s) => new
            {
                group = g.Name,
                description = g.Description,
                rating = s.Select(s => s.Rating).Aggregate((x, y) => x + y) / (double)s.Count(),
                Students = s.Select(s => new {  FullName = s.Name, AvgMark = s.Rating })
            });
            return JsonSerializer.Serialize(result, options);
        }
    }   
}
