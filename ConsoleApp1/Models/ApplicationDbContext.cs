using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class ApplicationDbContext : DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-3OTPLG0\SQLINSTANCE;Database=EFCourse;User Id=sa;Password=Salmo091;")
				.EnableSensitiveDataLogging(true)
				.UseLoggerFactory(MyLoggerFactory);
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Estudiante>().Property(x => x.Apellido).HasField("_apellido");

            base.OnModelCreating(modelBuilder);
        }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
		{
			builder
			   .AddFilter((category, level) =>
				   category == DbLoggerCategory.Database.Command.Name
				   && level == LogLevel.Information)
			   .AddConsole();
		});
		
		DbSet<Estudiante> Estudiantes { get; set; }
	}
}
