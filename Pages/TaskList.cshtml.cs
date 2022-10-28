using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TaskSchedulingSystem.Model;
using TaskSchedulingSystem.Services;

namespace TaskSchedulingSystem.Pages
{
    public class TaskListModel : PageModel
    {
        // Need variable for service
        JsonFileTaskService TaskService;

        // Need variable for Task Record
        public IEnumerable<Task> Tasks;

        public TaskListModel(JsonFileTaskService taskservice)
        {
            TaskService = taskservice;
        }
        public void OnGet()
        {
            Tasks = TaskService.getTaskRecord();
        }
    }
}
