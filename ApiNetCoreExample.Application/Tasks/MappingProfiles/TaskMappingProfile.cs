using ApiNetCoreExample.Application.Tasks.Commands;
using ApiNetCoreExample.Application.Tasks.Dto;
using ApiNetCoreExample.Core.Entities;
using AutoMapper;

namespace ApiNetCoreExample.Application.Tasks.MappingProfiles
{
    public class TaskMappingProfile : Profile
    {
        public TaskMappingProfile()
        {
            CreateMap<CreateTaskCommand, Task>();
            CreateMap<UpdateTaskCommand, Task>();
            CreateMap<Task, TaskDto>();
        }
    }
}