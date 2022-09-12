using eKino.Model;
using System;
using System.Collections.Generic;

namespace eKino.Services.Database
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; } = null!;
        public decimal Amount { get; set; }
    }
}
