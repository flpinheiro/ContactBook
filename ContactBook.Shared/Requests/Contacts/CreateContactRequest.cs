using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Shared.Requests.Contacts
{
    public record CreateContactRequest: BasicRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }

        public string? Company { get; set; }
        public string? Department { get; set; }
        public string? Title { get; set; }

        public string? Notes { get; set; }
    }
}
