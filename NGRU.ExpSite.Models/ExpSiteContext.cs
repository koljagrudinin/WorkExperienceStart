using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGRU.ExpSite.Models.Entities;

namespace NGRU.ExpSite.Models
{
	public class ExpSiteContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public ExpSiteContext() : base()
		{

		}
	}
}
