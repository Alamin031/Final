﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DeliveryManReview
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string review { get; set; }
        [Required]
        public DateTime date { get; set; }
        //Required]
        //ForeignKey("user")]
        //ublic int u_id { get; set; }

        //ublic virtual User user { get; set; }
        public virtual ICollection<DeliveryMan> DeliveryMan { get; set; }
        public DeliveryManReview()
        {
            DeliveryMan = new List<DeliveryMan>();

        }

    }
}