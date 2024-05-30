using System.Text.Json.Serialization;

namespace ContactBook.Shared.Models;

public class ContactPhone: BasicModel<int>
{
    public string Phone { get; set; } = null!;
    [JsonIgnore]
    public Contact? Contact { get; set; }
    [JsonIgnore]
    public int ContactId { get; set; }
}
