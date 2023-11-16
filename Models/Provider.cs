using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
	public class Provider
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; } = default!;
	}
}
