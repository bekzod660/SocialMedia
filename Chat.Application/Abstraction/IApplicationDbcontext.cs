using Chat.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chat.Application.Abstraction
{
    public interface IApplicationDbcontext
    {
        DbSet<Post> Posts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Comment> Comments { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
