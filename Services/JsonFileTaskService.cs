using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TaskSchedulingSystem.Model;

namespace TaskSchedulingSystem.Services
{
    public class JsonFileTaskService
    {
        // Json -> Program
        // Need a vraiable for home/root address & then generate file address & then do file handling

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        // Set Actual Hosting Environment  E.g: [Here We don't know the environment](?) / Our file name
        public JsonFileTaskService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Generate File Address
        public string FileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "tasks.json");
            }
        }

        // File Handling
        public IEnumerable<Task> getTaskRecord()
        {
            using (var filestream = File.OpenText(FileAddress))
            {
                return JsonSerializer.Deserialize<Task[]>(filestream.ReadToEnd());
            }
        }
    }
}
