using EasyBudget.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.Data.Factories
{
    internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args = null)
        {
            var dataService = new DataService();
            var conString = dataService.GetConfigurationJson();
            var connStr = conString.ConnectionString;
            var options = new DbContextOptionsBuilder<AppDbContext>();

            options.UseNpgsql(connStr);

            return new AppDbContext(options.Options);
        }
    }
}
