using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestBlazorServer.EntityFrameworkCore
{
    public static class TestBlazorServerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestBlazorServerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestBlazorServerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
