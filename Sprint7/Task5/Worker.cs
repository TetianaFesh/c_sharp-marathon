using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sprint7.Task5
{
    [Serializable]
    class Worker
    {
        private int Id { get; set; }
        [JsonPropertyName("Full name")]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public Worker(string _name, decimal _salary, Department _department)
        {
            Name = _name;
            Salary = _salary;
            Department = _department;
        }

        public Worker() { }

        public string Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues= true
            };
            return JsonSerializer.Serialize<Worker>(new Worker(Name, Salary, Department), options);
        }

        public static Worker Deserializer(string json)
        {
            return JsonSerializer.Deserialize<Worker>(json);
        }
    }
}
