using ContactBook.Infra.Context;
using ContactBook.Infra.Repositories;
using ContactBook.Shared.Handlers.Repositories;

namespace ContactBook.Infra;

internal class UnitOfWork(AppDbContext _context) : IUnitOfWork
{
    public IContactRepository ContactRepository 
        => new Lazy<IContactRepository>(() => new ContactRepository(_context)).Value;
}
