namespace ContactBook.Shared.Handlers.Repositories;

public interface IUnitOfWork
{
    IContactRepository ContactRepository { get; }
}