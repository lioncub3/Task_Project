using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Project.Models;

namespace Task_Project.Data
{
    public class TasksContext: DbContext
    {

        public DbSet<TaskInfo> TaskInfos { get; set; }

        public TasksContext(DbContextOptions options) : base(options)
        {

        }
    }
}
