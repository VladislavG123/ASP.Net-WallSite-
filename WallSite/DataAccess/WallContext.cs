using System;
using System.Data.Entity;
using System.Linq;
using WallSite.Models;

namespace WallSite.DataAccess
{
    public class WallContext : DbContext
    {
       public DbSet<Comment> Comments { get; set; }
    }

}