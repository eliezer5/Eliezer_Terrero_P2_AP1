using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Models;

namespace Eliezer_Terrero_P2_AP1.API.DAL
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Vehiculos> Vehiculos { get; set;}
		public DbSet<Accesorios> Accesorios { get; set; }
		public DbSet<VehiculosDetalle> VehiculosDetalle { get; set; }
	}
}
