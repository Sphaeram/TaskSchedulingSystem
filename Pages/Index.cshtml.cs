using TaskSchedulingSystem.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TaskSchedulingSystem.Services;

namespace TaskSchedulingSystem.Pages
{
    public class IndexModel : PageModel
    {
        // Need variable for service
        JsonFileTaskService TaskService;

        // Need variable for Task Record
        public IEnumerable<Task> Tasks;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonFileTaskService service)
        {
            _logger = logger;
            TaskService = service;
        }

        public void OnGet()
        {
            Tasks = TaskService.getTaskRecord();
        }
    }
}
