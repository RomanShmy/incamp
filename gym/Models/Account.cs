using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace gym
{
    public class Account
    {
        public int Id { get; set;}
        public Balance BalanceId { get; set;}

        public ICollection<Transaction> Transactions { get; set;}
    }
}