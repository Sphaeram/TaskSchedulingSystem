using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace TaskSchedulingSystem.Services
{
    public class CSSFileService
    {
        public IWebHostEnvironment Environment { get; set; }

        public CSSFileService(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public string FileAddress
        {
            get
            {
                return Path.Combine(Environment.WebRootPath, "data", "style.css");
            }
        }

        public string getCSSFile()
        {
            using (var filestream = File.OpenText(FileAddress))
            {
                return filestream.ReadToEnd();
            }
        }
    }
}
