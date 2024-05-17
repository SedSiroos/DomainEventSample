using DomainEvent.Model;
using Framework.Domain;
using Microsoft.EntityFrameworkCore;

namespace DomainEvent.Core;

public class DomainEventContext : BaseContext
{
    public DbSet<Person> People { get; set; }
    public DomainEventContext(DbContextOptions<DomainEventContext> options):base(options){}
}