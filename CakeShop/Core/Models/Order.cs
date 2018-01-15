using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderPlacedTime { get; set; }

        [StringLength(255)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Required]
        public string LastName { get; set; }

        [StringLength(255)]
        [Required]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        public string AddressLine2 { get; set; }

        [StringLength(255)]
        [Required]
        public string City { get; set; }

        [StringLength(255)]
        [Required]
        public string State { get; set; }

        [StringLength(255)]
        [Required]
        public string Country { get; set; }

        [StringLength(6)]
        [Required]
        public string ZipCode { get; set; }

        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        public decimal OrderTotal { get; set; }

        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new Collection<OrderDetail>();
        }
    }
}
