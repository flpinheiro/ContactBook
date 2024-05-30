using ContactBook.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactBook.Infra.Mapping;

internal class ContactAddressMapping : IEntityTypeConfiguration<ContactAddress>
{
    void IEntityTypeConfiguration<ContactAddress>.Configure(EntityTypeBuilder<ContactAddress> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
