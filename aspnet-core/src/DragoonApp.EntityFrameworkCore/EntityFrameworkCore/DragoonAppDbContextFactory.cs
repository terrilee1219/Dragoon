using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DragoonApp.Configuration;
using DragoonApp.Web;

namespace DragoonApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DragoonAppDbContextFactory : IDesignTimeDbContextFactory<DragoonAppDbContext>
    {
        public DragoonAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DragoonAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DragoonAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DragoonAppConsts.ConnectionStringName));

            return new DragoonAppDbContext(builder.Options);
        }
    }
}
