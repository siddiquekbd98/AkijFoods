using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Models
{
	public class ColdDrinkContext:DbContext
	{
		public ColdDrinkContext(DbContextOptions<ColdDrinkContext> options) : base(options)
		{

		}
		public DbSet<ColdDrinks> ColdDrinks { get; set; }
		
	}
}
