using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace gym
{
    public class Transaction
    {
        public int Id { get; set;}
        public decimal Amount { get; set;}
        public DateTime Date { get; set;} = DateTime.UtcNow;
        public string Notes { get; set;}
        public int? AccountId { get; set;}
        public Account Account { get; set;}

    }
}