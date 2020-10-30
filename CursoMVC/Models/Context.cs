using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
	public class Context : DbContext
	{
		public DbSet<Categoria> Categorias { get; set; }

		public DbSet<Produto> Produtos { get; set; }

		public Context(DbContextOptions<Context> options) : base(options)
		{ }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");		
	}
		public virtual void SetModified(object entity)
		{
			Entry(entity).State = EntityState.Modified;
		}
	}
}
