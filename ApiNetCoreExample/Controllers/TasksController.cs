using ApiNetCoreExample.Application.Tasks.Commands;
using ApiNetCoreExample.Application.Tasks.Dto;
using ApiNetCoreExample.Application.Tasks.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetCoreExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TasksController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<TaskDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllTasksQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDto>> Get(int id)
        {
            return await Mediator.Send(new GetTaskByIdQuery { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTaskCommand command)
        {
            Response.StatusCode = 201;
            return await Mediator.Send(command);
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateTaskCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteTaskCommand { Id = id });
        }
    }
}
