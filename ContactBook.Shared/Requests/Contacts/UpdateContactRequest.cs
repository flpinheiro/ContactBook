namespace ContactBook.Shared.Requests.Contacts;

public record UpdateContactRequest : BasicRequest
{
    public int Id { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NickName { get; set; }

    public string? Company { get; set; }
    public string? Department { get; set; }
    public string? Title { get; set; }

    public string? Notes { get; set; }
}
