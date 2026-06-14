
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using SalesWebMvc.Models;
using System.Diagnostics;

namespace SalesWebMvc
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {

            _context = context;

        }

        public void Seed()
        {

            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return;
            }

            Department dp1 = new Department(1, "Eletronics");
            Department dp2 = new Department(2, "itens");
            Department dp3 = new Department(3, "Furniture");

            Seller s1 = new Seller(1, "moon", "moon@gmail.com", new DateTime(2001, 03, 11), 7900, dp1);
            Seller s2 = new Seller(2, "pontesafena", "pontesafena@gmail.com", new DateTime(2001, 07, 01), 3700, dp2);
            Seller s3 = new Seller(3, "davi", "davi@gmail.com", new DateTime(2001, 09, 11), 7700, dp3);

            SalesRecord sl1 = new SalesRecord(1, new DateTime(2023, 07, 03), 2179.11, SaleStatus.Billed, s1);
            SalesRecord sl2 = new SalesRecord(2, new DateTime(2024, 01, 09), 2700.79, SaleStatus.Billed, s1);
            SalesRecord sl3 = new SalesRecord(3, new DateTime(2026, 03, 17), 3911.91, SaleStatus.Billed, s1);

            SalesRecord sl4 = new SalesRecord(4, new DateTime(2023, 01, 07), 711.17, SaleStatus.Billed, s2);
            SalesRecord sl5 = new SalesRecord(5, new DateTime(2023, 11, 03), 379.99, SaleStatus.Billed, s2);
            SalesRecord sl6 = new SalesRecord(6, new DateTime(2023, 07, 03), 179.00, SaleStatus.Billed, s2);

            SalesRecord sl7 = new SalesRecord(7, new DateTime(2023, 03, 03), 2119.31, SaleStatus.Billed, s3);
            SalesRecord sl8 = new SalesRecord(8, new DateTime(2023, 07, 01), 2131.71, SaleStatus.Billed, s3);
            SalesRecord sl9 = new SalesRecord(9, new DateTime(2025, 01, 09), 219.91, SaleStatus.Billed, s3);

            _context.Department.AddRange(dp1, dp2, dp3);
            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecords.AddRange
            (
                sl1, sl2, sl3,
                sl4, sl5, sl6,
                sl7, sl8, sl9
            );

            _context.SaveChanges();

        }

    }
}
