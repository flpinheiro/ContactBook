using ContactBook.Shared.Models;

namespace ContactBook.Shared.Responses;

public record BasicResponse<TData> (TData? Data) where TData : BasicModel<int>;
