using ApiNetCoreExample.Application.Interfaces;

namespace ApiNetCoreExample.Infrastructure.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;
        }
        public ITaskRepository Tasks { get; }
    }
}
