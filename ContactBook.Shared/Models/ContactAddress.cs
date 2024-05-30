using System.Text.Json.Serialization;

namespace ContactBook.Shared.Models;

public class ContactAddress: BasicModel<int>
{
    public string Address { get; set; } = null!;

    [JsonIgnore]
    public Contact? Contact { get; set; }
    [JsonIgnore]
    public int ContactId { get; set; }
}
