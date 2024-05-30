using System.Text.Json.Serialization;

namespace ContactBook.Shared.Models;

public class ContactEmail: BasicModel<int>
{
    public string Email { get; set; } = null!;
    [JsonIgnore]
    public Contact? Contact { get; set; }
    [JsonIgnore]
    public int ContactId { get; set; }
}
