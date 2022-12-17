using CSharp_Exam.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    class dbContext : DbContext
    {
        public dbContext():base("MyConnectionString")
        {

        }

        public virtual DbSet<Item> Items { get; set; }
    }
}
