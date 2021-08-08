using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Models
{
	public class ColdDrinks
	{
		[Key]
		public int ColdDrinksId { get; set; }
		public string ColdDrinksName { get; set; }
		public decimal Quantity { get; set; }
		public decimal UnitPrice { get; set; }
	}
}
