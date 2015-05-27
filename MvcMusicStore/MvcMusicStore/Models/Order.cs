using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string UserName { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last Name is required.")]
        [StringLength(160)]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage="Email is not a vlaid email address.")]
        public string Email { get; set; }

        [Compare("Email")]
        public string EmailConfirm { get; set; }

        public decimal Total { get; set; }

        //public List<OrderDetail> OrderDetails { get; set; }
    }
}