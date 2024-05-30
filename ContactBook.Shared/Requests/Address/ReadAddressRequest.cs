namespace ContactBook.Shared.Requests.Address;

public record ReadAddressRequest
{
    public int id { get; set; }
    public int ContactId { get; set; }
}

public record ReadAllAddressRequest
{
    public int ContactId { get; set; }
}

public record CreateAddresRequest
{
    public int ContactId { get; set; }
    public string Address { get; set; } = null!;
}

public record UpdateAddresRequest
{
    public int id { get; set; }
    public int ContactId { get; set; }
    public string Address { get; set; } = null!;
}

public record DeleteAddressRequest
{
    public int id { get; set; }
    public int ContactId { get; set; }
}
