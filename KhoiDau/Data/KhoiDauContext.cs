using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KhoiDau.Models;

namespace KhoiDau.Data
{
    public class KhoiDauContext : DbContext
    {
        public KhoiDauContext (DbContextOptions<KhoiDauContext> options)
            : base(options)
        {
        }

        public DbSet<KhoiDau.Models.SanPham> SanPham { get; set; } = default!;
    }
}
