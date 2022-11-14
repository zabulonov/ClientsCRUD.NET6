using System;
using Microsoft.EntityFrameworkCore;
using ClientsCRUD.Models;


namespace ClientsCRUD.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Clients> clients { get; set; } = null!;
    }
}

