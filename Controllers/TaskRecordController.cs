using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskSchedulingSystem.Model;
using TaskSchedulingSystem.Services;

namespace TaskSchedulingSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaskRecordController : ControllerBase
    {
        JsonFileTaskService TaskService;

        public TaskRecordController(JsonFileTaskService taskservice)
        {
            this.TaskService = taskservice;
        }

        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return TaskService.getTaskRecord();
        }
    }
}
