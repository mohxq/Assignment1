using System;

namespace SedapMakan.Models
{
    public class EWalletTransaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // Topup or Order
    }
}
