
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {

        private readonly SalesWebMvcContext Context;

        public SellerService(SalesWebMvcContext _context)
        {

            Context = _context;

        }

        public List<Seller> Sellers()
        {

            return Context.Seller.ToList();

        }

    }
}
