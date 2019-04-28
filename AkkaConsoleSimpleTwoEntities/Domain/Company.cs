using System;
using System.Collections.Generic;
using System.Text;

namespace AkkaConsoleSimpleTwoActors.Domain
{
    public class Company
    {
        public string TaxDocument { get; private set; }
        public string Description { get; private set; }

        public Company(string taxDocument, string description)
        {
            this.TaxDocument = taxDocument;
            this.Description = description;
        }
    }
}
