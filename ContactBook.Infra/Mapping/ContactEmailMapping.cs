using ContactBook.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactBook.Infra.Mapping;

internal class ContactEmailMapping : IEntityTypeConfiguration<ContactEmail>
{
    void IEntityTypeConfiguration<ContactEmail>.Configure(EntityTypeBuilder<ContactEmail> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
