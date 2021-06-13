using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalChallenge.Models
{
	public class SchoolContext : DbContext
	{
		public SchoolContext(): base()
		{

		}
		// Entities
		public DbSet<Student> Students { get; set; }
	}
}