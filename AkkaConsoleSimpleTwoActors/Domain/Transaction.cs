using System;
using System.Collections.Generic;
using System.Text;
using AkkaConsoleSimpleTwoActorsCall.ValueObj;

namespace AkkaConsoleSimpleTwoActorsCall.Domain
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public double Amount { get; set; }
        public string AffiliationCode { get; set; }

        public Transaction()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
        }
    }
}
