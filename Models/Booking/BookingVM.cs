﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Test.Models
{
    public class BookingVM
    {
        public int Id { get; set; }

        [Required]
        [Display (Name ="Pickup Time")]
        public DateTime PickUpTime { get; set; }

        [Required]
        [Display(Name = "From Address ")]
        public string FromAddress { get; set; }

        [Required]
        [Display(Name = "To Address")]
        public string ToAddress { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Is Paid ")]
        public bool IsPaid { get; set; }

        [Display(Name = "Car")]

        public int CarId { get; set; }

        [Display(Name = "Driver")]
        public int DriverId { get; set; }

        public List<int> PassengerId { get; set; }


        [Required]
        [Display(Name = "Payment Date")]
        public DateTime PaymentDate { get; set; }



    }
}
