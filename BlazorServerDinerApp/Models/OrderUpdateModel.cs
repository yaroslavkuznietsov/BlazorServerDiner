using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDinerApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [DisplayName("Name for the Order")]
        [MaxLength(20, ErrorMessage = "You need to keep the name to a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to keep the name to a min of 3 characters")]
        [Required]
        public string OrderName { get; set; }
    }
}
