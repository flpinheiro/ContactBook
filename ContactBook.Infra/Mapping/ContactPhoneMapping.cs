using ContactBook.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactBook.Infra.Mapping;

internal class ContactPhoneMapping : IEntityTypeConfiguration<ContactPhone>
{
    public void Configure(EntityTypeBuilder<ContactPhone> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
