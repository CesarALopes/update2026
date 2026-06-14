using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellerController : Controller
    {

        private readonly SellerService _sellerService;

        public SellerController(SellerService sellerService)
        {

            _sellerService = sellerService;

        }

        public IActionResult Index()
        {

            var sl = _sellerService.Sellers();
                    
            return View(sl);


        }
    }
}
