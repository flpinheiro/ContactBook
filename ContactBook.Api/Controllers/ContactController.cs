using ContactBook.Shared.Dtos;
using ContactBook.Shared.Handlers.Services;
using ContactBook.Shared.Models;
using ContactBook.Shared.Requests.Contacts;
using ContactBook.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ContactBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController (IContactService service) : ControllerBase
{
    [HttpGet]
    public async Task<PagedResponse<ContactDto>> GetContact([FromQuery] ReadAllContactRequest request) => 
        new PagedResponse<ContactDto>(await service.GetAll(request));

    [HttpGet("{Id}")]
    public async Task<BasicResponse<Contact>> GetContactById([FromRoute] ReadContactRequest request) => 
        new BasicResponse<Contact>(await service.GetById(request));

    [HttpPost]
    public async Task PostContact([FromBody] CreateContactRequest request) 
    {
        await service.Save(request);
        throw new NotImplementedException();
    }

    [HttpPut]
    public BasicResponse<Contact> PutContact([FromBody] UpdateContactRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{Id}")]
    public void DeleteContact([FromRoute] DeleteContactRequest request) 
    {
        throw new NotImplementedException();
    }

}
