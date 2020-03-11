using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
	{
		public void Configure(EntityTypeBuilder<Account> builder)
		{
            builder.HasData
            (
                new Account
                {
                    Id = new Guid("03e91478-5608-4132-a753-d494dafce00b"),
                    OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"),
                    AccountType = "Domestic",
                    DateCreated = new DateTime(2003, 12, 15)
                },
                new Account
                {
                    Id = new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"),
                    OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"),
                    AccountType = "Foreign",
                    DateCreated = new DateTime(2010, 6, 20)
                }
            );
        }
	}
}
