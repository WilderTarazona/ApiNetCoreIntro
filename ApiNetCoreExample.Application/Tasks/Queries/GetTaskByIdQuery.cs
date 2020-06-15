using ApiNetCoreExample.Application.Tasks.Dto;
using MediatR;

namespace ApiNetCoreExample.Application.Tasks.Queries
{
    public class GetTaskByIdQuery : IRequest<TaskDto>
    {
        public int Id { get; set; }
    }
}