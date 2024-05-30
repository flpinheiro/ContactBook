using ContactBook.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ContactBook.Infra.Context;

internal sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<ContactAddress> Address { get; set; } = null!;
    public DbSet<ContactPhone> Phones { get; set; } = null!;
    public DbSet<ContactEmail> Emails { get; set; } = null!;
    public DbSet<ContactDate> Dates { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());
}
