using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DBContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
