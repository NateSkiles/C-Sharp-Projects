using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.DataAccess
{
	public class PeopleContext : DbContext
	{
		// Constructor - Inherits from base class. Pass options to the base class
		public PeopleContext(DbContextOptions options) : base(options) { }

		// Properties
		public DbSet<Person> People { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Email> EmailAddresses { get; set; }
	}
}
