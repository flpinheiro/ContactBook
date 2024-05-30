using ContactBook.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactBook.Infra.Mapping;

internal class ContactMapping : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany(contact => contact.Phones).WithOne(phone => phone.Contact).HasForeignKey(phone => phone.ContactId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(contact => contact.Address).WithOne(address => address.Contact).HasForeignKey(address => address.ContactId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(contact => contact.Emails).WithOne(email => email.Contact).HasForeignKey(email => email.ContactId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(contact => contact.Dates).WithOne(date => date.Contact).HasForeignKey(date => date.ContactId).OnDelete(DeleteBehavior.Cascade);
    }
}
