using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "History of Ottoman", Price = 100m },
                new Book { Id = 2, Title = "Great Russia", Price = 90m },
                new Book { Id = 3, Title = "Middle-Earth", Price = 150m }
            );
        }
    }
}
