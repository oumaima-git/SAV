using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SAV.core.Entities;

namespace WebApplication6.Data
{
    public class WebApplication6Context : DbContext
    {
        public WebApplication6Context (DbContextOptions<WebApplication6Context> options)
            : base(options)
        {
        }

        
    }
}
