using System.Text.Json.Serialization;
using System.Text.Json;

namespace TaskSchedulingSystem.Model
{
    public class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        public string due { get; set; }
        public string priority { get; set; }
        public string image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Task>(this);
        }
    }
}
