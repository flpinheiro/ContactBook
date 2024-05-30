using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Shared.Requests.Contacts
{
    public record DeleteContactRequest: BasicRequest
    {
        public int Id { get; set; }
    }
}
