using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaNhacManagerWeb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
        {

        }
        //Khai báo thuộc tính ánh xạ CSDL
        public DbSet<DiaNhac> DiaNhacs { set; get; }
    }
}
