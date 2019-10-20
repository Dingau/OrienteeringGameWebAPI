using CoordinatesAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoordinatesAPI.Contexts
{
    public class CoordinatesDbContext : DbContext
    {
        public CoordinatesDbContext() : base("name = DefaultConnection")
        { }
        public DbSet<AppInfoModel> Coordinates { get; set; }
    }
}