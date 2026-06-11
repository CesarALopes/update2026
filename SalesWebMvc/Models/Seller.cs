namespace SalesWebMvc.Models
{
    public class Seller
    {

        int Id { get; set; }

        string Name { get; set; }        
        
        string Email { get; set; }

        public DateTime BirthDate { get; set; }

        double BaseSalary { get; set; }



    }
}
