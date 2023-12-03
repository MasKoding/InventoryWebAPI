using InventoryWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebAPI.Context
{
    public class InventoryContext :DbContext
    {
        public InventoryContext()
        {

        }
        public InventoryContext(DbContextOptions<InventoryContext> options) :base(options)
        {

        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }




    }
}
