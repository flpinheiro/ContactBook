using ContactBook.Shared.Dtos;
using ContactBook.Shared.Handlers.Repositories;
using ContactBook.Shared.Handlers.Services;
using ContactBook.Shared.Models;
using ContactBook.Shared.Requests.Contacts;

namespace ContactBook.Api.Services;

public class ContactService(IUnitOfWork _uow) : IContactService
{
    public async Task<IEnumerable<ContactDto>> GetAll(ReadAllContactRequest request) => 
        await _uow.ContactRepository.GetAll(request);

    public async Task<Contact?> GetById(ReadContactRequest request)
    {
        return await _uow.ContactRepository.Get(request.Id);
    }

    public async Task<int> Save(CreateContactRequest request)
    {
        var contact = new Contact
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            NickName =request.NickName,
            Company = request.Company,
            Title = request.Title,
            Notes = request.Notes,
            Department = request.Department,
        };
        return await _uow.ContactRepository.Save(contact);
    }
}
