using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using AkkaConsoleSimpleTwoActors.Domain;

namespace AkkaConsoleSimpleTwoActors.Library
{
    public class ReportCompanyProcess
    {
        public void SendReport(Company company)
        {
            Console.WriteLine("Company report: ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"TaxDocument:  {company.TaxDocument}");
            Console.WriteLine($"Description:  {company.Description}\n");
        }
    }
}
