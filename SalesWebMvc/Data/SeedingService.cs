using SalesWebMvc.Models;

namespace SalesWebMvc.Data
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
            if (_context.Seller.Any() || _context.SalesRecord.Any() || _context.Department.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Musical Instruments");
            Department d3 = new Department(3, "Sport");
            Department d4 = new Department(4, "Rock Articles");

            Seller s1 = new Seller(1, "Axl Rose", "gunsnroses@gmail.com", new DateTime(1962, 2, 20), 1800.00, d4);
            Seller s2 = new Seller(2, "Slash", "gunsnroses@gmail.com", new DateTime(1967, 4, 21), 1400.00, d2);
            Seller s3 = new Seller(3, "Dave Mustaine", "megadeth@gmail.com", new DateTime(1964, 3, 29), 1100.00, d2);
            Seller s4 = new Seller(4, "Sylvester Stalone", "rocky@yahoo.com", new DateTime(1954, 8, 21), 2000.00, d3);
            Seller s5 = new Seller(5, "Bill Gates", "microsoft@gmail.com", new DateTime(1951, 6, 28), 2200.00, d1);
            Seller s6 = new Seller(6, "yngwie Malmsteen", "risingforce@hotmail.com", new DateTime(1964, 6, 30), 1000.00, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 04, 13), 1100.00, Models.Enums.SaleStatus.Billed, s2);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 04, 12), 100.00, Models.Enums.SaleStatus.Pending, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 04, 11), 250.00, Models.Enums.SaleStatus.Billed, s5);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 04, 9), 330.00, Models.Enums.SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 04, 8), 400.00, Models.Enums.SaleStatus.Billed, s6);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 04, 7), 80.00, Models.Enums.SaleStatus.Pending, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 04, 6), 950.00, Models.Enums.SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 04, 4), 600.00, Models.Enums.SaleStatus.Canceled, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 04, 2), 10.00, Models.Enums.SaleStatus.Billed, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 04, 1), 40.00, Models.Enums.SaleStatus.Pending, s5);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();
        }


    }
}
