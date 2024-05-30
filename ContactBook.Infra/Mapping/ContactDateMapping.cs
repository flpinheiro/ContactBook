using ContactBook.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactBook.Infra.Mapping;

internal class ContactDateMapping : IEntityTypeConfiguration<ContactDate>
{
    void IEntityTypeConfiguration<ContactDate>.Configure(EntityTypeBuilder<ContactDate> builder)
    {
        builder.HasKey(x => x.Id);
    }
}