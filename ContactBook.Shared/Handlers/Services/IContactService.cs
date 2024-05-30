using ContactBook.Shared.Dtos;
using ContactBook.Shared.Models;
using ContactBook.Shared.Requests.Contacts;

namespace ContactBook.Shared.Handlers.Services;

public interface IContactService
{
    Task<IEnumerable<ContactDto>> GetAll(Requests.Contacts.ReadAllContactRequest request);
    Task<Contact?> GetById(ReadContactRequest readContactRequest);
    Task<int> Save(CreateContactRequest request);
}
