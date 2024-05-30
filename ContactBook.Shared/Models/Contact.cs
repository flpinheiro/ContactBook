namespace ContactBook.Shared.Models;
public class Contact : BasicModel<int>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NickName { get; set; }

    public string? Company { get; set; }
    public string? Department { get; set; }
    public string? Title { get; set; }

    public string? Notes { get; set; }

    public IEnumerable<ContactPhone>? Phones { get; set; } 
    public IEnumerable<ContactAddress>? Address { get; set; } 
    public IEnumerable<ContactEmail>? Emails { get; set; } 
    public IEnumerable<ContactDate>? Dates { get; set; } 
}
