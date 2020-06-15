using ApiNetCoreExample.Application.Tasks.Dto;
using MediatR;
using System.Collections.Generic;

namespace ApiNetCoreExample.Application.Tasks.Queries
{
    public class GetAllTasksQuery : IRequest<List<TaskDto>>
    {
    }
}