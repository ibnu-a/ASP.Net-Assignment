using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNet_API_Project.Models
{
    [Table("Tb_M_Accounts")]
    public class Accounts
    {
            [Key]
            [ForeignKey("Employee")]
            public int Id { get; set; }
            [DataType(DataType.Password)]
            [Required(ErrorMessage = "Password is required")]
            public string Password { get; set; }
            public virtual Employees Employee { get; set; }
    }
}