using Microsoft.EntityFrameworkCore;

namespace todolist;

public class Db : DbContext
{
    public DbSet<todolist.models.Task> Tasks { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
#if DEBUG
        // デバッグ中は、Dockerで立っているDBに外から接続する
        optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=todolist; User ID=sa; Password=jMJWpbHG75Gw; TrustServerCertificate=true;");
#else
            // 本番環境では、Docker内のDBに接続する
        optionsBuilder.UseSqlServer(@"Data Source=db; Initial Catalog=todolist; User ID=sa; Password=jMJWpbHG75Gw; TrustServerCertificate=true;");
#endif
    }
}