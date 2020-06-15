using ApiNetCoreExample.Application.Interfaces;
using ApiNetCoreExample.Application.Tasks.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApiNetCoreExample.Application.Tasks.Handlers
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTaskCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Tasks.Add(_mapper.Map<Core.Entities.Task>(request));
            return result;
        }
    }
}
