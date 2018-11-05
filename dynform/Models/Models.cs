using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dynform.Models
{
    public class DynformContext: DbContext
    {
        public DynformContext(DbContextOptions<DynformContext> options): base(options)
        {

        }
    }
}
