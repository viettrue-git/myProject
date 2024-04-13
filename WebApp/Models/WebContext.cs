using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebApp.Models
{
    public class WebContext : DbContext
    {
        public readonly IOptions<AppSettings> _appsettings;
        public DbSet<Banner> banners { set; get; }        // bảng banner
        public DbSet<User> users { set; get; }                // bảng user


        public WebContext(IOptions<AppSettings> appsettings)
        {
            _appsettings = appsettings;
        }
        // chuỗi kết nối với tên db sẽ làm  việc đặt là webdb
        public const string ConnectStrring = @"Data Source=DESKTOP-JC3AARP\\TRANGANH;Initial Catalog=KipaInfomation;User ID=sa;Password=123456789@;TrustServerCertificate=True";
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = _appsettings.Value.DefaultConnection;
            optionsBuilder.UseSqlServer(ConnectStrring);
            //optionsBuilder.UseLoggerFactory(GetLoggerFactory());       // bật logger
        }
    }
}
