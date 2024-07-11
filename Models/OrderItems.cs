﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmTicketShop.Models
{
    public class OrderItems
    {
        [Key]
        public int Id { get; set; }
        
        public int Amout { get; set; }

        public double Price { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]

        public Movie Movie { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]

        public Order Order { get; set; }
    }
}