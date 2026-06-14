namespace SalesWebMvc.Models
{
    public class Seller
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public double BaseSalary { get; set; }

        public Department DepartMent { get; set; }

        public ICollection<SalesRecord> SR { get; set; } = new List<SalesRecord>();

        public void AddSales(SalesRecord Sr)
        {

            SR.Add(Sr);

        }

        public void RemoveSales(SalesRecord Sr)
        {
                     
            SR.Remove(Sr);      
                    
        }

        public double TotalSales(DateTime initial, DateTime final)
        {

            return SR.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        }
        public Seller()
        {
        }
        public Seller(int id, string name, string email, DateTime birthdate, double basesalary, Department department)
        {

            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthdate;
            BaseSalary = basesalary;
            DepartMent = department;
                    
        }


     
    }
}
