using ApiNetCoreExample.Application.Interfaces;
using ApiNetCoreExample.Application.Tasks.Dto;
using ApiNetCoreExample.Application.Tasks.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApiNetCoreExample.Application.Tasks.Handlers
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTaskByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<TaskDto> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Tasks.Get(request.Id);
            return _mapper.Map<TaskDto>(result);
        }
    }
}