using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    [Table("StudentInfo")] //=> StudentInfo
    public class Student
    {
        public int StudentId { get; set; }

        [MaxLength(20)] //=> nvarchar(20)
        [Required]
        public string FirstName { get; set; }

        [MaxLength(20)]
        [Required]
        public string? LastName { get; set; }

        [Column("DOB")] //=> column name DOB
        public DateTime DateOfBirth { get; set; }

        public decimal Height { get; set; }

        public int AddressId { get; set; } //Foregin key
        public virtual Address? StudentAddress { get; set; } //1-1

        public int GradeId { get; set; } //Foregin key

        public virtual Grade Grade { get; set; } //1-n
    }

}
