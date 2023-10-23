using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_Segund_mvc.Models;
using Microsoft.AspNetCore.SignalR;

namespace AMS23_Segund_mvc.Data.Repository
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOpition<ApplicationDataContext> opition): base(opition){}

        public DbSet<CategoryModel> Category {get;set;}

    }
    

    
}