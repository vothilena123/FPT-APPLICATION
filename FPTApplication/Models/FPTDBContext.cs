using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace FPTApplication.Models
{
    public class FPTDBContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Book> Books { get; set; }
        
        public FPTDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static FPTDBContext Create()
        {
            return new FPTDBContext();
        }
    }
}