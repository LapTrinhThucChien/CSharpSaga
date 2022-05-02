using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Grade
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? GradeName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Section { get; set; }

        public virtual List<Student>? Students { get; set; } //1-n
    }
}
