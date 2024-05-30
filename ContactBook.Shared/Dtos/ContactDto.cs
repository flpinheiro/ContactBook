using ContactBook.Shared.Models;

namespace ContactBook.Shared.Dtos;

public class ContactDto :BasicModel<int>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
