namespace ApiNetCoreExample.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository Tasks { get; }
    }
}
