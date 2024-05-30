﻿using System.Text.Json.Serialization;

namespace ContactBook.Shared.Models;

public class ContactDate: BasicModel<int>
{
    public DateOnly Date { get; set; } = new();

    [JsonIgnore]
    public Contact? Contact { get; set; }
    [JsonIgnore]
    public int ContactId { get; set; }
}
