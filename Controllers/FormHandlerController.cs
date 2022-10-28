using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using TaskSchedulingSystem.Model;
using TaskSchedulingSystem.Services;

namespace TaskSchedulingSystem.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonFileTaskService TaskService;

        public FormHandlerController(JsonFileTaskService taskService)
        {
            TaskService = taskService;
        }

        [HttpGet]
        public string Get(int id, string name, string priority, string due, string image)
        {
            //return "Hello";

            Task obj = new Task();
            obj.id = id;
            obj.name = name;
            obj.priority = priority;
            obj.due = due;
            obj.image = image;

            IEnumerable<Task> Tasks = TaskService.getTaskRecord();
            List<Task> tasklist = Tasks.ToList();
            tasklist.Add(obj);
            return JsonSerializer.Serialize<List<Task>>(tasklist);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
