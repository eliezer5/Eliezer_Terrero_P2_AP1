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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Accesorios>().HasData(new List<Accesorios>()
			{
				new Accesorios() {AccesoriosId=1, Descripcion ="Camara Trasera"},
				new Accesorios() {AccesoriosId=2, Descripcion ="Pantalla interior"},
				new Accesorios() {AccesoriosId=3, Descripcion ="Interior en Piel"},
				new Accesorios() {AccesoriosId=4, Descripcion ="Sun Roof"},
				new Accesorios() {AccesoriosId=5, Descripcion ="Aros de Lujo"}

			});
		}
	}
}
