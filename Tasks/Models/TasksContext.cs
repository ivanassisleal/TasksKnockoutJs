using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class TasksContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}