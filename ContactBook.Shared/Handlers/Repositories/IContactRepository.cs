using ContactBook.Shared.Dtos;
using ContactBook.Shared.Models;
using ContactBook.Shared.Requests.Contacts;

namespace ContactBook.Shared.Handlers.Repositories
{
    public interface IContactRepository
    {
        Task<Contact?> Get(int id);
        Task<IEnumerable<ContactDto>> GetAll(ReadAllContactRequest request);
        Task<int> Save(Contact contact);
        Task Update(Contact contact);
        Task Delete(int id);
    }
}
