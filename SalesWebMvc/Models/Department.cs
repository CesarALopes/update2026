namespace SalesWebMvc.Models
{
    public class Department
    {

        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public ICollection<Seller> SLs { get; set; } = new List<Seller>();

        public Department() 
        {
        }

        public Department(int  id, string name)
        {

            Id = id;
            Name = name;

        }

        public void AddSeller(Seller Sl)
        {

            SLs.Add(Sl);

        }

        public double TotalSales(DateTime initial, DateTime final)
        {

            return SLs.Sum(sl => sl.TotalSales(initial, final));

        }

    }
}
