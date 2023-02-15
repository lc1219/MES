using Mes.Domain.Devices;
using Mes.Domain.Meteriel;
using Mes.Domain.Productions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.EFCors
{
    public class MyDbContext:DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=127.0.0.1;database=Month0205;uid=sa;pwd=1234");
            }
        }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<ProductionsStatus> ProductionsStatuses { get; set; }
        public DbSet<ProductionsType> ProductionsTypes { get; set; }
        public DbSet<Meteriel> Meteriels { get; set; }
        public DbSet<CheckSystem> CheckSystems { get; set; }
        public DbSet<MaterielProperty> MaterielProperties { get; set; }
        public DbSet<Packet> Packets { get; set; }
        public DbSet<PurchaseUnit> PurchaseUnits { get; set; }
        public DbSet<BasicUnits> BasicUnits { get; set; }
    }
}
