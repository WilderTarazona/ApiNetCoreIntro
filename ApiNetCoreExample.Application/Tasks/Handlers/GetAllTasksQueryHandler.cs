using ApiNetCoreExample.Application.Interfaces;
using ApiNetCoreExample.Application.Tasks.Dto;
using ApiNetCoreExample.Application.Tasks.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiNetCoreExample.Application.Tasks.Handlers
{
    public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, List<TaskDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTasksQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<TaskDto>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Tasks.GetAll();
            return _mapper.Map<List<TaskDto>>(result.ToList());
        }
    }
}