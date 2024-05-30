using ContactBook.Infra.Context;
using ContactBook.Shared.Dtos;
using ContactBook.Shared.Handlers.Repositories;
using ContactBook.Shared.Models;
using ContactBook.Shared.Requests.Contacts;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Infra.Repositories;

internal class ContactRepository (AppDbContext _context) : IContactRepository
{
    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Contact?> Get(int id) => 
        await _context
            .Contacts
            .Where(x => x.Id == id)
            .Include(x => x.Address)
            .Include(x => x.Phones)
            .Include(x => x.Emails)
            .Include(x => x.Dates)
            .FirstOrDefaultAsync();

    public async Task<IEnumerable<ContactDto>> GetAll(ReadAllContactRequest request) => 
        await _context.Contacts
            .IgnoreAutoIncludes()
            .Select(x => new ContactDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName
            })
            .Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize)
            .ToListAsync();

    public async Task<int> Save(Contact contact)
    {
        _context.Contacts.Add(contact);

        await _context.SaveChangesAsync();
        return contact.Id;
    }

    public Task Update(Contact contact)
    {
        throw new NotImplementedException();
    }
}
