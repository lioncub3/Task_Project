using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Project.Models
{
    public class TaskInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
