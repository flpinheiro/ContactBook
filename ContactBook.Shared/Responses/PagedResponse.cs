using ContactBook.Shared.Models;

namespace ContactBook.Shared.Responses;

public record PagedResponse<TData> (IEnumerable<TData> Data) where TData : BasicModel<int>;
