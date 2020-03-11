using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
	{
		public void Configure(EntityTypeBuilder<Owner> builder)
		{
            builder.HasData
            (
                new Owner
                {
                    Id = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"),
                    Name = "John Keen",
                    Address = "61 Wellfield Road",
                    DateOfBirth = new DateTime(1980, 8, 19)
                },
                new Owner
                {
                    Id = new Guid("261e1685-cf26-494c-b17c-3546e65f5620"),
                    Name = "Anna Bosh",
                    Address = "27 Colored Row",
                    DateOfBirth = new DateTime(1974, 4, 17)
                }
            );
        }
	}
}
