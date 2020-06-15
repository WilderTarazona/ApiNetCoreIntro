using ApiNetCoreExample.Application.Interfaces;
using ApiNetCoreExample.Application.Tasks.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApiNetCoreExample.Application.Tasks.Handlers
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTaskCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Tasks.Delete(request.Id);
            return result;
        }
    }
}
