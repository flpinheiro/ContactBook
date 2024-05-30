namespace ContactBook.Shared.Models;

public abstract class BasicModel<TKey>
{
    public TKey? Id { get; set; }
}
