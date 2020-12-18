using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sprint7.Task5
{
    [Serializable]
    class Department
    {
        [JsonPropertyName("Full name")]
        public string Name { get; set; }
        public int Id { get; set; }
        public Worker Manager { get; set; }

        public Department(string _name, int _id, Worker _manager)
        {
            Name = _name;
            Id = _id;
            Manager = _manager;
        }

        public Department() { }
        public string Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };
            return JsonSerializer.Serialize<Department>(new Department(Name, Id, Manager), options);
        }

        public static Department Deserializer(string json)
        {
            return JsonSerializer.Deserialize<Department>(json);
        }
    }
}
