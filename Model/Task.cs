using System.Text.Json.Serialization;
using System.Text.Json;

namespace TaskSchedulingSystem.Model
{
    public class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonPropertyName("due")]
        public string due_date { get; set; }
        public string priority { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Task>(this);
        }
    }
}
