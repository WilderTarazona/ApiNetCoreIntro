using ApiNetCoreExample.Core.Enums;
using MediatR;
using System;

namespace ApiNetCoreExample.Application.Tasks.Commands
{
    public class UpdateTaskCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}