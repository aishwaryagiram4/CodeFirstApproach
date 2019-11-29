using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstMigrationas.Models
{
    public class Students
    {
        [Key]
        public long StudId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(100)]
        public string DeptName { get; set; }

        [Range(0,100)]
        public int Marks { get; set; }
        [StringLength(100)]
        public string Performance { get; set; }

        
       
    }
}
