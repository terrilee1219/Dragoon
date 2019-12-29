using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DragoonApp.EntityFrameworkCore
{
    public static class DragoonAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DragoonAppDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DragoonAppDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
