namespace ContactBook.Shared.Requests;

public record PagedRequest(int PageSize = Configuration.PageSizeDefault, int PageNumber = Configuration.PageNumberDefault);
