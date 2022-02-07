using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace LibraryApi.Models
{
  public class UsersContext : DbContext
  {
    public UsersContext(DbContextOptions<UsersContext> options)
        : base(options)
    {
    }

    public DbSet<Users> Users { get; set; } = null!;
  }
}