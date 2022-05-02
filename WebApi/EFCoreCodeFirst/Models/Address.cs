using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Address
    {
        public int AddressId { get; set; } //Id, id, ID => set column is primary key

        [Required]
        [MaxLength(50)]
        public string Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }
    }
}
