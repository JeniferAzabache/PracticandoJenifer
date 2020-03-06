using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext() : base("connBD")
        {
             
        
    }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
