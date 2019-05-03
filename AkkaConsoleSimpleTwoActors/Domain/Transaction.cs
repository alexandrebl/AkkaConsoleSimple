using System;
using System.Collections.Generic;
using System.Text;
using AkkaConsoleSimpleTwoActorsCall.ValueObj;

namespace AkkaConsoleSimpleTwoActorsCall.Domain
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public double Amount { get; private set; }
        public string AffiliationCode { get; private set; }

        public Transaction(TransactionType transactionType, double amount, string affiliationCode)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            TransactionType = transactionType;
            Amount = amount;
            AffiliationCode = affiliationCode;
        }
    }
}
