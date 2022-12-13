using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestBlazorServer.Authorization.Roles;
using TestBlazorServer.Authorization.Users;
using TestBlazorServer.MultiTenancy;

namespace TestBlazorServer.EntityFrameworkCore
{
    public class TestBlazorServerDbContext : AbpZeroDbContext<Tenant, Role, User, TestBlazorServerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestBlazorServerDbContext(DbContextOptions<TestBlazorServerDbContext> options)
            : base(options)
        {
        }
    }
}
