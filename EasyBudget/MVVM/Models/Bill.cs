using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBudget.MVVM.Models
{
    internal class Bill
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? PayeeName { get; set; }
        [Required]
        [StringLength(150)]
        public string? AccountNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string? ConfirmationNumber { get; set; }
        [Required]
        public decimal DueAmount { get; set; }
        public decimal PaidAmount { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime PaidDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
